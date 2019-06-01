﻿using System;
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
            var movie = new Movie() { Id = 1, Name = "Shrek" };
            var customers = new List<Customer>()
            {
                new Customer {Id = 1, Name = "Customer 1" },
                new Customer {Id = 2, Name = "Customer 2" },
                new Customer {Id = 3, Name = "Customer 3" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content(String.Format("id={0}", id));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Index()
        {
            var movies = new List<Movie>()
            {
                new Movie { Id = 1, Name = "Shrek"},
                new Movie { Id = 1, Name = "Wall-E"}
            };

            var viewModel = new MoviesViewModel()
            {
                Movies = movies
            };

            return View(viewModel);
        }
    }
}