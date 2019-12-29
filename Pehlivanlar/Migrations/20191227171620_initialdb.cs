using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pehlivanlar.Migrations
{
    public partial class initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new 
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CanChangePassword = table.Column<bool>(nullable: false),
                    CanChangePrice = table.Column<bool>(nullable: false),
                    CanChangeStock = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PehUsers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 256, nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PehUsers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PehUsers_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CanChangePassword", "CanChangePrice", "CanChangeStock", "Name" },
                values: new object[] { 1, true, true, true, "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CanChangePassword", "CanChangePrice", "CanChangeStock", "Name" },
                values: new object[] { 2, false, false, false, "Personel" });

            migrationBuilder.InsertData(
                table: "PehUsers",
                columns: new[] { "ID", "CreatedTime", "Name", "Password", "RoleID", "Surname", "UserName" },
                values: new object[] { 1, new DateTime(2019, 12, 27, 20, 16, 19, 782, DateTimeKind.Local).AddTicks(4498), "Ayvaz", "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918", 1, "Pehlivan", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_PehUsers_RoleID",
                table: "PehUsers",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PehUsers");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
