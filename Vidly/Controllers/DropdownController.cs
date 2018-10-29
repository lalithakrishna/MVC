using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class DropdownController : Controller
    {
        // GET: Dropdown
        public ActionResult Dropdown()
        {
            var country = new List<Dropdown>
            {
                new Dropdown {Name = "USA",Id = 1},
                new Dropdown {Name = "UK",Id = 2}
            };
            var countries = new DropdownViewmodel
            {
                country = country
            };
            return View(countries);
        }
    }
}