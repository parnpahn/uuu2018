using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UUUMod517.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string Index2()
        {
            return "Hello MVC";
        }
        public ActionResult Index3()
        {
            ViewData["data"] = System.DateTime.Now;
            ViewBag.data2 = System.DateTime.Now;


            return View();
        }
    }
}