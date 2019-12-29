using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Pehlivanlar.Migrations
{
    public partial class SupAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 12, 27, 22, 43, 3, 269, DateTimeKind.Local).AddTicks(532));


            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Location", "Name" },
                values: new object[] { 2, "Manisa", "Vestel" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Location", "Name" },
                values: new object[] { 1, "İstanbul", "Beko" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 12, 27, 22, 36, 52, 880, DateTimeKind.Local).AddTicks(97));
        }
    }
}
