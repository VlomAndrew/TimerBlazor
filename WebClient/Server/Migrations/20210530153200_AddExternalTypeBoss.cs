using Microsoft.EntityFrameworkCore.Migrations;

namespace WebClient.Server.Migrations
{
    public partial class AddExternalTypeBoss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41952694-817f-4c7f-865c-d0c9034f6ac1");

            migrationBuilder.AddColumn<int>(
                name: "ExternalType",
                table: "Bosses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "129f75a7-31a7-4a9b-81e5-383685eff604", "029a56b1-d8b9-4a91-a587-f43c813c7de9", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "129f75a7-31a7-4a9b-81e5-383685eff604");

            migrationBuilder.DropColumn(
                name: "ExternalType",
                table: "Bosses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41952694-817f-4c7f-865c-d0c9034f6ac1", "fc2c31a3-45ca-4255-adfc-5cae1f64f6ff", "Admin", "ADMIN" });
        }
    }
}
