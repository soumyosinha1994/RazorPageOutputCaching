using Microsoft.EntityFrameworkCore;
using RazorPageOutputCaching.Model;

namespace RazorPageOutputCaching.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Soumyo", Address = "Jamshedpur" },
            new Employee { Id = 2, Name = "Ankita", Address = "Kolkata" },
            new Employee { Id = 3, Name = "Deep", Address = "Pune" });
        }

    }
}
