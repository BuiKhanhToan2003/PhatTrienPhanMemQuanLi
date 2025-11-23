using Microsoft.EntityFrameworkCore;
using DemoMVC304.Models;

namespace DemoMVC304.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}

        public DbSet<Person> Person { get; set; }
    }
}
