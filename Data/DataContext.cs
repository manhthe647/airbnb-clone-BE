using airbnb_clone_BE.Data.Entity;
using airbnb_clone_BE.Data.SeedData;
using Microsoft.EntityFrameworkCore;

namespace airbnb_clone_BE.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //data seeding
            modelBuilder.SeedDataGenerate();
        }
        public DbSet<Palace> Palaces { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<PalaceAmenity> PalaceAmenities { get; set; }
    }
}
