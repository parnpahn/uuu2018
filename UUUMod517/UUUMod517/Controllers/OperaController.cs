using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UUUMod517.Models;
using UUUMod517.DAL;


namespace UUUMod517.Controllers
{
    public class OperaController : Controller
    {
        private OperaContext context = new OperaContext();
        // GET: Opera
        public ActionResult Index()
        {
            Opera o = new Opera()
            {
                OperaID = 1,
                Title = "胖胖胖胖",
                Year = 107,
                Composer = "胖胖胖胖胖胖胖胖"
            };
            return View(o);
        }

        public ActionResult Index2(int ?year)
        {
            Opera o = new Opera()
            {
                OperaID = 1,
                Title = "胖胖胖胖",
                Year = year.Value,
                Composer = "胖胖胖胖胖胖胖胖"
            };
            return View("index",o);
        }

        public ActionResult Index3(Opera o)
        {
           return View( o);
        }
        public ActionResult Index4(Opera o)
        {
            return View(context.Operas.ToList());
        }

    }
}