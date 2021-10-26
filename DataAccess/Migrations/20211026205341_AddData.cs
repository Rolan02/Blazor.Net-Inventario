using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategotyId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumeria" },
                    { "SLD", "Salud" },
                    { "VDJ", "Video Juegos" }
                });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseId", "WarehouseAddres", "WarehouseName" },
                values: new object[,]
                {
                    { "b50f31e4-50d6-49be-8913-71714cd43091", "Calle Antezana", "Bodega Central" },
                    { "2e7e6021-5bb3-447e-9b69-655a604b4a19", "Calle Atahuallapa", "Bodega Norte" },
                    { "3b9fd4de-5c2e-4fd1-9948-5f42fabc749c", "Calle Villa Pagador", "Bodega Sud" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategotyId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategotyId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategotyId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategotyId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategotyId",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategotyId",
                keyValue: "VDJ");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseId",
                keyValue: "2e7e6021-5bb3-447e-9b69-655a604b4a19");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseId",
                keyValue: "3b9fd4de-5c2e-4fd1-9948-5f42fabc749c");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseId",
                keyValue: "b50f31e4-50d6-49be-8913-71714cd43091");
        }
    }
}
