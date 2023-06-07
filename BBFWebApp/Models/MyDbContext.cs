using Microsoft.EntityFrameworkCore;

namespace BBFWebApp.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<News> News { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("NewsDb");
        }
    }
}
