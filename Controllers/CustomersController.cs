using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VioRentals.Data;
using VioRentals.Models;

namespace VioRentals.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();
            return View(customer);
        }

        public ActionResult New()
        {
            return View();
        }
    }
}