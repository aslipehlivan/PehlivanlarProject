using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pehlivanlar.Migrations
{
    public partial class delete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SupplierID",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 21, 17, 36, 18, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 21, 17, 36, 20, DateTimeKind.Local).AddTicks(6710));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 20, 37, 39, 555, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 20, 37, 39, 559, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
