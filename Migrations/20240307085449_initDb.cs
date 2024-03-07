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
                    AmentityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                columns: new[] { "Id", "AmentityName", "Icon" },
                values: new object[,]
                {
                    { 1, "Wifi", "iconoir:wifi" },
                    { 2, "TV", "gala:tv" },
                    { 3, "Bếp", "mdi:stove" },
                    { 4, "Máy giặt", "icon-park-outline:washing-machine" },
                    { 5, "Chỗ đỗ xe miễn phí tại nơi ở", "fluent:vehicle-car-16-regular" },
                    { 6, "Chỗ đỗ xe có thu phí trong khuôn viên", "fluent:vehicle-car-parking-32-regular" },
                    { 7, "Điều hòa nhiệt độ", "material-symbols:mode-cool" },
                    { 8, "Không gian làm việc riêng", "lucide:lamp-desk" }
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
