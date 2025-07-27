using Microsoft.EntityFrameworkCore;
using PodCast.DataContext.Entities;

namespace PodCast.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<SpeakerProfession> SpeakerProfessions { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Bio> Bios { get; set; }
    }
}