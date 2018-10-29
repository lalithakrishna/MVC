using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext=new EmployeeContext();
            Player player = employeeContext.Player.Single(ply => ply.PlayerId == id);

            return View(player);
        }

        public ActionResult Index(string teamname)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Player> players = employeeContext.Player.Where(ply=>ply.TeamName==teamname).ToList();

            return View(players);
        }
    }
}