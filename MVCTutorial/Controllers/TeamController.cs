using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            EmployeeContext employeeContext=new EmployeeContext();
            List<Team> team = employeeContext.Teams.ToList();

            return View(team);
        }
    }
}