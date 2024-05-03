using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindAMovie.Models;
using FindAMovie.Models.ViewModels;

namespace FindAMovie.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // Movies
        public ActionResult Index()
        {
            return View();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() 
            { 
                Name = "Iron Man" 
            };

            var customers = new List<Customer>
            {
                new Customer { Id = 2, Name = "Aaron Rodgers" },
                new Customer { Id = 1, Name = "Brett Favre" },
                new Customer { Id = 3, Name = "Jordan Love" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            // 1 way to pass data to the view (inflexible approach)
            //ViewData["Movie"] = movie;
            
            // 2nd way to pass data to the view (inflexible approach)
            //ViewBag.Movie = movie;

            // 3rd and preferred approach of passing data to the view
            // passes the entire movie object through the View parameter
            return View(viewModel);

            // example of a redirect with parameter values
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        [Route("movies/released/{year:regex(\\d{4}):range(1111, 9999)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year.ToString("0000") + "/" + month.ToString("00"));
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // GET: Movies/Details/1
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        // nullable types: all of the following do the same thing
        // int?
        // Nullable<int>
        // Nullable<System.Int32>
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if (String.IsNullOrEmpty(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}