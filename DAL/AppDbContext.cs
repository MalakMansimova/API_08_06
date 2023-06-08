using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;

namespace ProductAPI.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
    }
}
