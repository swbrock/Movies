using Movies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieListContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieListContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovies()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterMovies(MovieLists ml)
        {
            //Puts what the user just inserted in the new movie into the database
            blahContext.Add(ml);
            blahContext.SaveChanges();

            return View("Index");
        }
    }
}
