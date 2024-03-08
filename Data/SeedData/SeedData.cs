using airbnb_clone_BE.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace airbnb_clone_BE.Data.SeedData
{
    public static class SeedData
    {
        public static void SeedDataGenerate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amenity>().HasData(
                new Amenity() { Id = 1, AmenityName = "Wifi", Icon= "430077_fi_wi_wifi_icon.png" },
                new Amenity() { Id = 2, AmenityName = "TV", Icon = "172609_tv_icon.png" },
                new Amenity() { Id = 3, AmenityName = "Bếp", Icon = "976611_appliances_cook_cooker_kitchen_oven_icon.png" },
                new Amenity() { Id = 4, AmenityName = "Máy giặt", Icon= "9132480_washing machine_laundry_cleaning_housekeeping_washing_icon.png" },
                new Amenity() { Id = 5, AmenityName = "Chỗ đỗ xe miễn phí tại nơi ở", Icon= "753908_cars_automobile_car_vehicle_icon.png" },
                new Amenity() { Id = 6, AmenityName = "Chỗ đỗ xe có thu phí trong khuôn viên", Icon = "751082_parking_car_packing_sign_vehicle_icon.png" },
                new Amenity() { Id = 7, AmenityName = "Điều hòa nhiệt độ", Icon = "9035523_snow_outline_icon.png" },
                new Amenity() { Id = 8, AmenityName = "Không gian làm việc riêng", Icon = "1250326_desk_lamp_light_table_icon.png" }
            );
        }
    }
}
