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
                name: "Palaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palaces", x => x.Id);
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "PalaceAmenities");

            migrationBuilder.DropTable(
                name: "Palaces");
        }
    }
}
