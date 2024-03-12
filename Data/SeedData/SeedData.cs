using airbnb_clone_BE.Data.Entity;
using airbnb_clone_BE.Shared;
using Microsoft.EntityFrameworkCore;

namespace airbnb_clone_BE.Data.SeedData
{
    public static class SeedData
    {
        public static void SeedDataGenerate(this ModelBuilder modelBuilder)
        {
            //Amenity
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

            //Palace
            modelBuilder.Entity<Palace>().HasData(
                new Palace() { 
                   Id = 1, Title = "JW Marriott Hotel Hanoi", 
                   Description = "Khách sạn 5 sao đẳng cấp thế giới",
                   Latitude = 21.007126149125504,
                   Longitude = 105.78321866192687,
                   City = "Hà Nội",
                   District = "Nam Từ Liêm",
                   AddressLine = "",
                   PalaceType = PalaceTypeEnum.E,
                   AccommodationType = AccommodationTypeEnum.B,
                   Price = 6804000,
                   IsActive = true,
                   //UserId = 1
                },
                 new Palace()
                 {
                     Id = 2,
                     Title = "Khách sạn Mường Thanh Grand Hà Nội",
                     Description = "Chuỗi khách sạn uy tín, chất lượng số 1 VN, Cơ sở Linh Đàm",
                     Latitude = 20.973837575971725,
                     Longitude = 105.82807578105918,
                     City = "Hà Nội",
                     District = "Đại Kim",
                     AddressLine = "Nghiêm Xuân Yêm",
                     PalaceType = PalaceTypeEnum.E,
                     AccommodationType = AccommodationTypeEnum.B,
                     Price = 1179360,
                     IsActive = true,
                     //UserId = 1
                 },
                  new Palace()
                  {
                      Id = 3,
                      Title = "Flamingo Dai Lai Resort",
                      Description = "Chuỗi khách sạn uy tín, chất lượng số 1 VN, Cơ sở Linh Đàm",
                      Latitude = 21.34369020525775,
                      Longitude = 105.71707285877919,
                      City = "Vĩnh Phúc",
                      District = "Phúc Yên",
                      AddressLine = "Thôn Đại Quang, Ngọc Thanh",
                      PalaceType = PalaceTypeEnum.E,
                      AccommodationType = AccommodationTypeEnum.B,
                      Price = 904000,
                      IsActive = true,
                      //UserId = 1
                  },
                  new Palace()
                  {
                      Id = 4,
                      Title = "Nhà trọ khép kín đối diện Bạch Mai",
                      Description = "Gần Bách Kinh xâ",
                      Latitude = 21.003443567243497,
                      Longitude = 105.84342799299425,
                      City = "Hà Nội",
                      District = "Hai Bà Trưng",
                      AddressLine = "55 Giải Phóng, Đồng Tâm",
                      PalaceType = PalaceTypeEnum.A,
                      AccommodationType = AccommodationTypeEnum.A,
                      Price = 411000,
                      IsActive = true,
                      //UserId = 1
                  },
                  new Palace()
                  {
                      Id = 5,
                      Title = "Căn hộ tầng 22A8 Park Hill 1",
                      Description = "View đẹp gần Times City",
                      Latitude = 20.99415779906403,
                      Longitude = 105.8685235322548,
                      City = "Hà Nội",
                      District = "Hoàng Mai",
                      AddressLine = "Vĩnh Phú",
                      PalaceType = PalaceTypeEnum.B,
                      AccommodationType = AccommodationTypeEnum.A,
                      Price = 360000,
                      IsActive = true,
                      //UserId = 1
                  }

            );

            
        }
    }
}
