using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pehlivanlar.Migrations
{
    public partial class pricesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 1, 18, 38, 56, 170, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 1, 18, 38, 56, 172, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "Price",
                value: 1200);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "Price",
                value: 1400);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "Price",
                value: 1500);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                column: "Price",
                value: 2400);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                column: "Price",
                value: 2800);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                column: "Price",
                value: 2000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                column: "Price",
                value: 3400);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                column: "Price",
                value: 1800);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                column: "Price",
                value: 2460);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                column: "Price",
                value: 1860);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                column: "Price",
                value: 1950);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                column: "Price",
                value: 2380);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 12, 31, 1, 42, 27, 500, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 12, 31, 1, 42, 27, 502, DateTimeKind.Local).AddTicks(5707));
        }
    }
}
