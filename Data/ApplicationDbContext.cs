using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VioRentals.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Models.Custumer> Customers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}