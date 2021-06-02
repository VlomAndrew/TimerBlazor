using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebClient.Server.Migrations
{
    public partial class NewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38ade3a8-c96b-4e16-87ee-82b6bb2b775a");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Monsters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "LogoImageData",
                table: "Monsters",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "History",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85e6c75f-34fd-4066-9043-008611666f9b", "95731e87-f47a-4544-903e-285bc6e02d2a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85e6c75f-34fd-4066-9043-008611666f9b");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "LogoImageData",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "Action",
                table: "History");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38ade3a8-c96b-4e16-87ee-82b6bb2b775a", "49df8453-2164-45d6-aa6e-68d7ee8bb2ec", "Admin", "ADMIN" });
        }
    }
}
