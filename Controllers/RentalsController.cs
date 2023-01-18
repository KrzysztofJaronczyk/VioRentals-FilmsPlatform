using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VioRentals.Data;
using VioRentals.Models;

namespace VioRentals.Controllers
{
    public class RentalsController : Controller
    {

        private readonly ApplicationDbContext _context;


        public IActionResult New()
        {
            return View();
        }


        public JsonResult Search(string searchTerm)
        {
            var result = _context.Customers.Where(c => c.Name.Contains(searchTerm) || c.Surname.Contains(searchTerm))
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.Surname
                }).ToList();
            return Json(result);
        }
    }
}
