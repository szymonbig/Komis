using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Komis.Models
{                          
    public class AppDbContext : IdentityDbContext<IdentityUser>                           //klasa generyczna
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {            
        }

        public DbSet<Samochod> Samochody { get; set; }
        public DbSet<Opinia> Opinie { get; set; }
    }
}
