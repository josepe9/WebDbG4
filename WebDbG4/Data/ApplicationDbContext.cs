using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebDbG4.Areas.Identity;

namespace WebDbG4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Dpto> Dptos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Personas> Personas { get; set; }
    }
}