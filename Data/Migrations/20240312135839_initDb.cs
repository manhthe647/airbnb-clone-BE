using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace airbnb_clone_BE.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmenityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CouponDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimesUsed = table.Column<int>(type: "int", nullable: false),
                    MaxUsage = table.Column<int>(type: "int", nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateExpired = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FromUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PalaceAmenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalaceId = table.Column<int>(type: "int", nullable: false),
                    AmenityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalaceAmenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PalaceBathrooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalaceId = table.Column<int>(type: "int", nullable: false),
                    PrivateClosedBathroom = table.Column<int>(type: "int", nullable: true),
                    PrivateBathroom = table.Column<int>(type: "int", nullable: true),
                    sharedBathroom = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalaceBathrooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PalaceCapacities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalaceId = table.Column<int>(type: "int", nullable: false),
                    GuestCount = table.Column<int>(type: "int", nullable: false),
                    BedCount = table.Column<int>(type: "int", nullable: false),
                    BedroomCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalaceCapacities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PalaceImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalaceId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sort = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalaceImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Palaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PalaceType = table.Column<byte>(type: "tinyint", nullable: true),
                    AccommodationType = table.Column<byte>(type: "tinyint", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PalaceSecurities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalaceId = table.Column<int>(type: "int", nullable: false),
                    hasCamera = table.Column<bool>(type: "bit", nullable: false),
                    hasSecurityStaff = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalaceSecurities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PalaceTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalaceId = table.Column<int>(type: "int", nullable: false),
                    Tag = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalaceTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalaceId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Star = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserFavoritePalaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PalaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavoritePalaces", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "AmenityName", "Icon" },
                values: new object[,]
                {
                    { 1, "Wifi", "430077_fi_wi_wifi_icon.png" },
                    { 2, "TV", "172609_tv_icon.png" },
                    { 3, "Bếp", "976611_appliances_cook_cooker_kitchen_oven_icon.png" },
                    { 4, "Máy giặt", "9132480_washing machine_laundry_cleaning_housekeeping_washing_icon.png" },
                    { 5, "Chỗ đỗ xe miễn phí tại nơi ở", "753908_cars_automobile_car_vehicle_icon.png" },
                    { 6, "Chỗ đỗ xe có thu phí trong khuôn viên", "751082_parking_car_packing_sign_vehicle_icon.png" },
                    { 7, "Điều hòa nhiệt độ", "9035523_snow_outline_icon.png" },
                    { 8, "Không gian làm việc riêng", "1250326_desk_lamp_light_table_icon.png" }
                });

            migrationBuilder.InsertData(
                table: "PalaceAmenities",
                columns: new[] { "Id", "AmenityId", "PalaceId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 7, 1 },
                    { 7, 8, 1 },
                    { 8, 1, 2 },
                    { 9, 2, 2 },
                    { 10, 3, 2 },
                    { 11, 4, 2 },
                    { 12, 5, 2 },
                    { 13, 7, 2 },
                    { 14, 8, 2 },
                    { 15, 1, 3 },
                    { 16, 2, 3 },
                    { 17, 3, 3 },
                    { 18, 4, 3 },
                    { 19, 5, 3 },
                    { 20, 7, 3 },
                    { 21, 1, 4 },
                    { 22, 3, 4 },
                    { 23, 7, 4 },
                    { 24, 2, 5 },
                    { 25, 3, 5 },
                    { 26, 4, 5 },
                    { 27, 6, 5 },
                    { 28, 7, 3 },
                    { 29, 8, 3 }
                });

            migrationBuilder.InsertData(
                table: "PalaceBathrooms",
                columns: new[] { "Id", "PalaceId", "PrivateBathroom", "PrivateClosedBathroom", "sharedBathroom" },
                values: new object[,]
                {
                    { 1, 1, null, 2, null },
                    { 2, 2, null, 2, null },
                    { 3, 3, null, 1, null },
                    { 4, 4, null, 1, null },
                    { 5, 5, null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "PalaceCapacities",
                columns: new[] { "Id", "BedCount", "BedroomCount", "GuestCount", "PalaceId" },
                values: new object[,]
                {
                    { 1, 4, 2, 8, 1 },
                    { 2, 2, 2, 4, 2 },
                    { 3, 1, 1, 2, 3 },
                    { 4, 1, 1, 1, 4 },
                    { 5, 2, 2, 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "PalaceSecurities",
                columns: new[] { "Id", "PalaceId", "hasCamera", "hasSecurityStaff" },
                values: new object[,]
                {
                    { 1, 1, true, true },
                    { 2, 2, true, true },
                    { 3, 3, true, true },
                    { 4, 4, true, false },
                    { 5, 5, true, true }
                });

            migrationBuilder.InsertData(
                table: "PalaceTags",
                columns: new[] { "Id", "PalaceId", "Tag" },
                values: new object[,]
                {
                    { 1, 1, (byte)1 },
                    { 2, 1, (byte)3 },
                    { 3, 1, (byte)4 },
                    { 4, 1, (byte)5 },
                    { 5, 2, (byte)3 },
                    { 6, 2, (byte)4 },
                    { 7, 2, (byte)5 },
                    { 8, 3, (byte)0 },
                    { 9, 3, (byte)1 },
                    { 10, 3, (byte)3 },
                    { 11, 4, (byte)4 },
                    { 12, 5, (byte)3 },
                    { 13, 5, (byte)4 },
                    { 14, 5, (byte)5 }
                });

            migrationBuilder.InsertData(
                table: "Palaces",
                columns: new[] { "Id", "AccommodationType", "AddressLine", "City", "Description", "District", "IsActive", "Latitude", "Longitude", "PalaceType", "Price", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, (byte)1, "", "Hà Nội", "Khách sạn 5 sao đẳng cấp thế giới", "Nam Từ Liêm", true, 21.007126149125504, 105.78321866192687, (byte)5, 6804000.0, "JW Marriott Hotel Hanoi", null },
                    { 2, (byte)1, "Nghiêm Xuân Yêm", "Hà Nội", "Chuỗi khách sạn uy tín, chất lượng số 1 VN, Cơ sở Linh Đàm", "Đại Kim", true, 20.973837575971725, 105.82807578105918, (byte)5, 1179360.0, "Khách sạn Mường Thanh Grand Hà Nội", null },
                    { 3, (byte)1, "Thôn Đại Quang, Ngọc Thanh", "Vĩnh Phúc", "Chuỗi khách sạn uy tín, chất lượng số 1 VN, Cơ sở Linh Đàm", "Phúc Yên", true, 21.343690205257751, 105.71707285877919, (byte)5, 904000.0, "Flamingo Dai Lai Resort", null },
                    { 4, (byte)0, "55 Giải Phóng, Đồng Tâm", "Hà Nội", "Gần Bách Kinh xâ", "Hai Bà Trưng", true, 21.003443567243497, 105.84342799299425, (byte)0, 411000.0, "Nhà trọ khép kín đối diện Bạch Mai", null },
                    { 5, (byte)0, "Vĩnh Phú", "Hà Nội", "View đẹp gần Times City", "Hoàng Mai", true, 20.99415779906403, 105.8685235322548, (byte)1, 360000.0, "Căn hộ tầng 22A8 Park Hill 1", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PalaceAmenities");

            migrationBuilder.DropTable(
                name: "PalaceBathrooms");

            migrationBuilder.DropTable(
                name: "PalaceCapacities");

            migrationBuilder.DropTable(
                name: "PalaceImages");

            migrationBuilder.DropTable(
                name: "Palaces");

            migrationBuilder.DropTable(
                name: "PalaceSecurities");

            migrationBuilder.DropTable(
                name: "PalaceTags");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "UserFavoritePalaces");
        }
    }
}
