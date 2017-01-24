using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BusinessFrontController : Controller
    {
        private WebApplicationContext db = new WebApplicationContext();
        // GET: BusinessFront
        public ActionResult Index()
        {
            List<Product> result = new List<Product>();
            result = (from p in db.Products select p).ToList();
            return View(result);
        }
    }
}