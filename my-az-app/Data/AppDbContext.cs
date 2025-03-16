using Microsoft.EntityFrameworkCore;

namespace my_az_app.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
    }
}
