using BikeEvents.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BikeEvents.DataAccess.Contexts
{
    public class EventsContext : DbContext
    {
        public EventsContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Event> Events { get; set; }
        
    }
}