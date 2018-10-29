using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["countries"]= new List<string>
            {
                "India",
                "USA",
                "UK"
            };

            //ViewBag.countries = new List<string>
            //{
            //    "India",
            //    "USA",
            //    "UK"
            //};

            return View();
        }
        
    }
}