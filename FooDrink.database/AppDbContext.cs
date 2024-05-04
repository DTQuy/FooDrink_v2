using Microsoft.EntityFrameworkCore;

namespace FooDrink.database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


    }
}