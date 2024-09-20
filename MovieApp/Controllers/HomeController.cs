using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using System.Diagnostics;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {

        private static List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "I Need Help", Director = "Your Mom", ReleaseYear = 2010, Genre = "Horror", ImageUrl="/Images/Honey.jpg"},
            new Movie { Title = "A Better Minecraft Movie", Director = "Steve", ReleaseYear = 2025, Genre = "Good Novie", ImageUrl="/Images/Minecraft.jfif"},
            new Movie { Title = "The Lord of the Bling", Director = "Francis Ford Coppola", ReleaseYear = 2003, Genre = "Flexing", ImageUrl="/Images/LordOfTheBling.jpg" },
            new Movie { Title = "Another Matt Damon Rescue Mission", Director = "Christopher Nolan", ReleaseYear = 2024, Genre = "Matt Damon", ImageUrl="/Images/Matt.jpg" },
            new Movie { Title = "I Am Leg", Director = "Leg", ReleaseYear = 2007, Genre = "Walking", ImageUrl="/Images/Leg.jpg" },
            new Movie { Title = "Detergent", Director = "Tide", ReleaseYear = 2014, Genre = "Cleaning", ImageUrl="/Images/Detergant.jpg" },
            new Movie { Title = "It's Over. It's Finally F*cking Over.", Director = "Too many people", ReleaseYear = 2015, Genre = "Cringe", ImageUrl="/Images/ItsOver.jpg" },
            new Movie { Title = "Star Shrek", Director = "Donke", ReleaseYear = 2012, Genre = "Shrek", ImageUrl="/Images/StarShrek.jpg" },
            new Movie { Title = "MMMMMNY", Director = "FFFFRO", ReleaseYear = 2012, Genre = "MMMMMM", ImageUrl="/Images/MMMY.jpg" }
        };


        public IActionResult Index()
        {
            return View(movies); 
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie newMovie)
        {
            if (newMovie != null)
            {
                movies.Add(newMovie);
            }
            return RedirectToAction("Index");
        }
    }
}