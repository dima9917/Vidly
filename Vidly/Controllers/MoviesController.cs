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
        #region context
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        #endregion
        public ActionResult New()
        {
            var genres = _context.Movies.Select(x => x.Genre).Distinct().ToList();
            //(from movie in _context.Movies
            // select movie.Genre).Distinct();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };
            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int Id)
        {
            var genres = _context.Movies.Select(x => x.Genre).Distinct().ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres,
                Movie = _context.Movies.Single(x => x.Id == Id)
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(x => x.Id == movie.Id);
                //TryUpdateModel(customerInDb); //Automatically update all fields in model
                //TryUpdateModel(customerInDb, "", new string[] { "Name", "Email" }); //Automatically update specified fields in model
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.Genre = movie.Genre;
                movieInDb.NumberInStock = movie.NumberInStock;

            }
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

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