using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pehlivanlar.Migrations
{
    public partial class newuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 12, 31, 1, 2, 12, 53, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.InsertData(
                table: "PehUsers",
                columns: new[] { "ID", "CreatedTime", "Name", "Password", "RoleID", "Surname", "UserName" },
                values: new object[] { 2, new DateTime(2019, 12, 31, 1, 2, 12, 56, DateTimeKind.Local).AddTicks(2493), "Yaşar", "840c2dce747a818940d2c83d918a712a890ccdcfa4a97b1ccb71ec5d6cea1bbb", 2, "Acar", "yasar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "PehUsers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 12, 30, 21, 14, 21, 22, DateTimeKind.Local).AddTicks(7292));
        }
    }
}
