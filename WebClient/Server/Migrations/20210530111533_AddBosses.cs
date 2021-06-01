using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebClient.Server.Migrations
{
    public partial class AddBosses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e587878b-7c2f-4534-888e-a05f854f2a55");

            migrationBuilder.CreateTable(
                name: "Bosses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeSpawn = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41952694-817f-4c7f-865c-d0c9034f6ac1", "fc2c31a3-45ca-4255-adfc-5cae1f64f6ff", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41952694-817f-4c7f-865c-d0c9034f6ac1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e587878b-7c2f-4534-888e-a05f854f2a55", "fc5e49a7-5d7b-4499-b956-ae6d6423b6d8", "Admin", "ADMIN" });
        }
    }
}
