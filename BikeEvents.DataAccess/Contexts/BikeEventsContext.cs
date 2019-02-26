using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BikeEvents.DataAccess.Contexts
{
    public class BikeEventsContext : IDesignTimeDbContextFactory<EventsContext>
    {
        public EventsContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EventsContext>();
            var connectionString = "server=localhost;database=bikeevents;uid=root;pwd=Facowe#18";
            builder.UseMySql(connectionString);
            return new EventsContext(builder.Options);
        }
    }
}