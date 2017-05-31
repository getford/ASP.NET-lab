using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L14.Controllers
{
    public class PhoneController : Controller
    {
        Models.PhoneContext phoneContext = new Models.PhoneContext();
        public ActionResult Browse()
        {
            return View("Browse", phoneContext.PhoneModels.AsEnumerable());
        }
        public ActionResult Add()
        {
            return View("Add");
        }
        [HttpPost]
        public ActionResult Add(Models.PhoneModel phoneModel)
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
        public ActionResult Update(Models.PhoneModel phoneModel)
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
            Models.PhoneModel model = phoneContext.PhoneModels.Find(id);
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

    }
}
