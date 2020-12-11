using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.API.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CatalogBrands",
                columns: new[] { "Id", "Brand" },
                values: new object[] { 1, "Default Brand" });

            migrationBuilder.InsertData(
                table: "CatalogTypes",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1, "Default Type" });

            migrationBuilder.InsertData(
                table: "CatalogItems",
                columns: new[] { "Id", "AvailableStock", "CatalogBrandId", "CatalogTypeId", "Description", "MaxStockThreshold", "Name", "OnReorder", "PictureFileName", "PictureUri", "Price", "RestockThreshold" },
                values: new object[,]
                {
                    { 1, 100, 1, 1, ".NET Bot Black Hoodie", 0, ".NET Bot Black Hoodie", false, "1.png", null, 19.5m, 0 },
                    { 2, 100, 1, 1, ".NET Black & White Mug", 0, ".NET Black & White Mug", false, "2.png", null, 8.50m, 0 },
                    { 3, 100, 1, 1, "Prism White T-Shirt", 0, "Prism White T-Shirt", false, "3.png", null, 12m, 0 },
                    { 4, 100, 1, 1, ".NET Foundation T-shirt", 0, ".NET Foundation T-shirt", false, "4.png", null, 12m, 0 },
                    { 5, 100, 1, 1, "Roslyn Red Sheet", 0, "Roslyn Red Sheet", false, "5.png", null, 8.5m, 0 },
                    { 6, 100, 1, 1, ".NET Blue Hoodie", 0, ".NET Blue Hoodie", false, "6.png", null, 12m, 0 },
                    { 7, 100, 1, 1, "Roslyn Red T-Shirt", 0, "Roslyn Red T-Shirt", false, "7.png", null, 12m, 0 },
                    { 8, 100, 1, 1, "Kudu Purple Hoodie", 0, "Kudu Purple Hoodie", false, "8.png", null, 8.5m, 0 },
                    { 9, 100, 1, 1, "Cup<T> White Mug", 0, "Cup<T> White Mug", false, "9.png", null, 12m, 0 },
                    { 10, 100, 1, 1, ".NET Foundation Sheet", 0, ".NET Foundation Sheet", false, "10.png", null, 12m, 0 },
                    { 11, 100, 1, 1, "Cup<T> Sheet", 0, "Cup<T> Sheet", false, "11.png", null, 8.5m, 0 },
                    { 12, 100, 1, 1, "Prism White TShirt", 0, "Prism White TShirt", false, "12.png", null, 12m, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CatalogItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
