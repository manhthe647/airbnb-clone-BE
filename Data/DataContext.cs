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
        public DbSet<Amenity> Amenities { get; set; }

        //public DbSet<AppUser> Users { get; set; }
        //public DbSet<Booking> Bookings { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Palace> Palaces { get; set; }
        public DbSet<PalaceAmenity> PalaceAmenities { get; set; }
        public DbSet<PalaceBathroom> PalaceBathrooms { get; set; }
        public DbSet<PalaceCapacity> PalaceCapacities { get; set; }
        public DbSet<PalaceImage> PalaceImages { get; set; }
        public DbSet<PalaceSecurity> PalaceSecurities { get; set; }
        public DbSet<PalaceTag> PalaceTags { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<UserFavoritePalace> UserFavoritePalaces { get; set; }

    }
}
