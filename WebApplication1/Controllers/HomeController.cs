using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our Company Profile";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }

        public ActionResult Vision()
        {
            ViewBag.Message = "Our Vision & Mission";

            return View();
        }

        public ActionResult Network()
        {
            ViewBag.Message = "Our Global Marketing Network";

            return View();
        }

        public ActionResult Culture()
        {
            ViewBag.Message = "Our Corporate Culture";

            return View();
        }

        public ActionResult Strategy()
        {
            ViewBag.Message = "Our Corporate Strategy";

            return View();
        }

        public ActionResult Careers()
        {
            ViewBag.Message = "Talent Strategy";

            return View();
        }

        public ActionResult Business()
        {
            ViewBag.Message = "Our Business";

            return View();
        }
    }
}