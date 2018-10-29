using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customers>
            {
                new Customers {Name = "Customer 1"},
                new Customers {Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewmodel
            {
                movie = movie,
                customers = customers 
            };

            return View(viewModel);
            //return View(movie);

            //ViewData["Movie"] = movie;
            //return View();

            //return Content("Hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, SortBy = "name"});
        }

        public ActionResult Edit(int Id)
        {
            return Content("id=" + Id);
        }

        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }

        [Route("Movies/Released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year+"/"+month);
        }
    }
}