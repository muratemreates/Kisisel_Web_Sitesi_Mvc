using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kisisel_Web_Sitesi.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hakkimda()
        {
            return View();
        }

        public ActionResult Skills()
        {
            return View();
        }
        public ActionResult Works()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}