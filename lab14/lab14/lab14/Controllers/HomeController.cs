using lab14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab14.Controllers
{
    public class HomeController : Controller
    {
        DataBaseContext dbc = new DataBaseContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Browse()
        {

            return View(dbc.User);
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Add(User user)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
                return View();
        }

        [HttpGet]
        public ViewResult Update()
        {
            return View();
        }
    }
}