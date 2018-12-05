using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
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

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.GenreType).ToList();

            return View(movies);
        }

        // GET: Movies/Details/1
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.GenreType).SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        /**
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            //return View(movie); // note: do not use ViewData or ViewBag, pass the model like so

            var customers = new List<Customer>
            {
                new Customer() {Name= "Customer 1"},
                new Customer() {Name= "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

            //return Content("Hello Laura");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }

        // http://localhost:59922/movies/edit/1 
        // http://localhost:59922/movies/edit?id=2
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // http://localhost:59922/movies
        // http://localhost:59922/movies?pageIndex=999&sortBy=Actor
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";

            return Content(String.Format("pageIndex{0}&sortBy={1}", pageIndex, sortBy));
        }

        // http://localhost:59922/movies/released/2015/08
        // this one wont be called as I have commented it out in RouteConfig.cs, and
        // have not used route attributes to define the route - whereas see below
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("ByReleaseDate: " + year + "/" + month);
        }

        // attribute route constraits
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content("ByReleaseYear: " + year + " / " + month);
        }
    */
    }
}