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

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() {Id = 1,Name = "Shreak !"},
                new Movie() {Id = 2,Name = "Mission Impossible"}
            };
        }
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public ActionResult Detail(int id)
        {
            var movie = GetMovies().SingleOrDefault(e => e.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }


        public ActionResult Random()
        {
            var movie = new Movie { Name = "ShreakM !" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
        

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        //}

        

       

        //mvcaction4 to create a new ActionResult Method

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

       
    }
}