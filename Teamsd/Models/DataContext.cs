using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Teamsd.Models
{
    public class DataContext: IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
        
        public DbSet<Team> TeamDB { get; set; }
        public DbSet<AppUser> AppUserDB { get; set; }
    }
}
