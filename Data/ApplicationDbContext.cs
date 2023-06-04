using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VioRentals.Core.Dtos;
using VioRentals.Core.Models;

namespace VioRentals.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public ApplicationDbContext()
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Movie> Movies { get; set; }
    public DbSet<MembershipType> MembershipTypes { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Rental> Rentals { get; set; }

    public DbSet<MovieDto> MovieDto { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=VioRentals;Trusted_Connection=True;");
    }
}