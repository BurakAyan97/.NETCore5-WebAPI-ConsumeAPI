using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Udemy.WebAPI.Migrations
{
    public partial class seedProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2023, 4, 30, 14, 50, 49, 395, DateTimeKind.Local).AddTicks(4834), null, "Bilgisayar", 15000m, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2023, 4, 3, 14, 50, 49, 396, DateTimeKind.Local).AddTicks(9774), null, "Telefon", 10000m, 500 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2023, 3, 4, 14, 50, 49, 396, DateTimeKind.Local).AddTicks(9787), null, "Klavye", 100m, 1000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
