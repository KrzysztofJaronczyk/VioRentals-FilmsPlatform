using Microsoft.AspNetCore.Mvc;

namespace VioRentals.Controllers
{
    public class RentalsController : Controller
    {
        public IActionResult New()
        {
            return View();
        }
    }
}
