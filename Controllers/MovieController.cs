using Microsoft.AspNetCore.Mvc;
using VioRentals.Models;
using VioRentals.ViewModels;

namespace VioRentals.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movies() { Name = "Shrek!" };

            var Custumers = new List<Custumer>
            {
                new Custumer { Name = "Custumer 1" },
                new Custumer { Name = "Custumer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = Custumers
            };
            return View(viewModel);
        }
    }
}