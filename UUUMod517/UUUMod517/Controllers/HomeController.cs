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


        public ActionResult Index4()
        {
            member m = new member()
            { id = 1, name = "parnpahn" };
            ViewData["data"] =m;


            return View();
        }

        public ActionResult Index5()
        {
            member m = new member()
            { id = 1, name = "parnpahn" };

            return View(m);
        }
    }


    public class member
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}