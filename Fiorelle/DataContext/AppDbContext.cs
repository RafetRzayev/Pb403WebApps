using Fiorelle.DataContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fiorelle.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<SliderContent> SliderContents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Logo> Logo { get; set; }
    }
}
