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
        private ApplicationDbContext _context = new ApplicationDbContext();

        public ActionResult Random()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Movie 1"},
                new Movie {Name = "Movie 2"}
            };


            return View(movies);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortby = "Name" });
        }

        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);
        }
        public ActionResult Index()
        {
            return View(_context.Movies);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Details(int Id)
        {
            return View(_context.Movies.SingleOrDefault(x => x.Id == Id));
            
        }


    }
}