using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L14.Controllers
{
    public class VideoController : Controller
    {
        Models.VideoContext videoContext = new Models.VideoContext();

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            return View(videoContext.VideoModels.AsEnumerable());


        }
        public ActionResult Index()
        {

            //return View();    
            ViewBag.fileId = videoContext.VideoModels.First().Id.ToString();

            return View(videoContext.VideoModels.AsEnumerable());

        }
        
        public ActionResult Video()
        {
            return PartialView(videoContext.VideoModels.AsEnumerable());
        }
        
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null && Path.GetExtension(file.FileName).Length>0)
            {
                Models.VideoModel a = new Models.VideoModel(file.FileName);
                videoContext.VideoModels.Add(a);
                videoContext.SaveChanges();
                var fileSavePath = HttpContext.Server.MapPath("~/VideoFiles\\") + a.Id  + Path.GetExtension(file.FileName);
                file.SaveAs(fileSavePath);
                ViewBag.fileId =a.Id.ToString() ;
            }
            
            return View("Index", videoContext.VideoModels.AsEnumerable());
        }
        
        public FileStreamResult GetVideo(string id)
        {
                return new FileStreamResult(new FileStream(HttpContext.Server.MapPath("~/VideoFiles\\") + id + ".mp4", FileMode.Open), "video/mp4");
        }
        public ActionResult SelectVideo(string id)
        {
            ViewBag.fileId = id;
            return View("Index",videoContext.VideoModels.AsEnumerable());

        }
        /*
        Models.VideoContext phoneContext = new Models.VideoContext();
        public ActionResult Browse()
        {
            return View("Browse", phoneContext.PhoneModels.AsEnumerable());
        }
        public ActionResult Add()
        {
            return View("Add");
        }
        [HttpPost]
        public ActionResult Add(Models.aaa phoneModel)
        {
            if (phoneModel.BDay < DateTime.Now.AddYears(-120))
            {
                ModelState.AddModelError("BDay", "Ошибка даты рождения");
            }
            if (ModelState.IsValid)
            {
                phoneContext.PhoneModels.Add(phoneModel);
                phoneContext.SaveChanges();
                return View("Browse", phoneContext.PhoneModels.AsEnumerable());
            }
            else return View();
        }
        public ActionResult Update(string id)
        {
            return View("Update", phoneContext.PhoneModels.Find(id));
        }
        [HttpPost]
        public ActionResult Update(Models.aaa phoneModel)
        {
            if (ModelState.IsValid)
            {
                phoneContext.Entry(phoneModel).State = System.Data.Entity.EntityState.Modified;
                phoneContext.SaveChanges();
                return View("Browse", phoneContext.PhoneModels.AsEnumerable());
            }
            return View("Update");
        }
        public ActionResult Delete(string id)
        {
            Models.aaa model = phoneContext.PhoneModels.Find(id);
            if (ModelState.IsValid && model != null)
            {
                phoneContext.PhoneModels.Remove(model);
                phoneContext.SaveChanges();
            }
            else
            {
                ViewBag.ErrorMessage = "Delete: Error";
            }
            return View("Browse", phoneContext.PhoneModels.AsEnumerable());
        }
        */
    }
}
