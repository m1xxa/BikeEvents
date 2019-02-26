
using BikeEvents.DomainModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BikeEvents.DataAccess.Contexts
{
    public class UserContext : IdentityDbContext<AppUser>
    {
        public UserContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<UserRole> UserRole { get; set; }
    }
}