using airbnb_clone_BE.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace airbnb_clone_BE.Data.SeedData
{
    public static class SeedData
    {
        public static void SeedDataGenerate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amenity>().HasData(
                new Amenity() { Id = 1, AmentityName = "Wifi", Icon= "iconoir:wifi" },
                new Amenity() { Id = 2, AmentityName = "TV", Icon = "gala:tv" },
                new Amenity() { Id = 3, AmentityName = "Bếp", Icon = "mdi:stove" },
                new Amenity() { Id = 4, AmentityName = "Máy giặt", Icon= "icon-park-outline:washing-machine" },
                new Amenity() { Id = 5, AmentityName = "Chỗ đỗ xe miễn phí tại nơi ở", Icon= "fluent:vehicle-car-16-regular" },
                new Amenity() { Id = 6, AmentityName = "Chỗ đỗ xe có thu phí trong khuôn viên", Icon = "fluent:vehicle-car-parking-32-regular" },
                new Amenity() { Id = 7, AmentityName = "Điều hòa nhiệt độ", Icon = "material-symbols:mode-cool" },
                new Amenity() { Id = 8, AmentityName = "Không gian làm việc riêng", Icon = "lucide:lamp-desk" }
            );
        }
    }
}
