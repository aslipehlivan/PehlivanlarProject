using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pehlivanlar.Migrations
{
    public partial class ProAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {

                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Properties = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    SupplierID = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },

                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 12, 27, 23, 46, 43, 461, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Code", "Color", "Properties", "Stock", "SupplierID" },
                values: new object[,]
                {
                    { 1, 1, "Quadro", "Siyah", 72, 12, 1 },
                    { 2, 1, "Smart", "Beyaz", 72, 3, 1 },
                    { 3, 1, "Smart", "Siyah", 105, 5, 2 },
                    { 4, 2, "B1 8459 SMN", "Beyaz", 465, 15, 1 },
                    { 5, 2, "B1 8550 SM", "Beyaz", 550, 6, 1 },
                    { 6, 2, "854270 MB", "Beyaz", 270, 15, 2 },
                    { 7, 3, "BK 6081 L A++", "Beyaz", 800, 17, 1 },
                    { 8, 3, "D4 6081 E", "Beyaz", 800, 9, 2 },
                    { 9, 3, "BK 8101 EYS", "Inox", 1000, 6, 2 },
                    { 10, 4, "BM 3003", "Beyaz", 3, 11, 1 },
                    { 11, 4, "BM 3003 SY", "Siyah", 3, 3, 1 },
                    { 12, 4, "BM 4004", "Beyaz", 4, 10, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 12, 27, 22, 50, 42, 341, DateTimeKind.Local).AddTicks(4781));
        }
    }
}
