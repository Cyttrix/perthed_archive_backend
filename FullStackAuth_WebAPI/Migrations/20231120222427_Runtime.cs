using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Runtime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5efe64c4-632f-4b5e-be5a-e0767dd53681");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7c47d8d-4ac0-4771-809c-a47893be27f2");

            migrationBuilder.AddColumn<string>(
                name: "Runtime",
                table: "Media",
                type: "longtext",
                nullable: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21b0046b-1d9e-40f2-9d38-f0cf82ddbeec", null, "Admin", "ADMIN" },
                    { "f9a1742f-2031-4e39-a8f3-303c1296f83c", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21b0046b-1d9e-40f2-9d38-f0cf82ddbeec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9a1742f-2031-4e39-a8f3-303c1296f83c");

            migrationBuilder.DropColumn(
                name: "Runtime",
                table: "Media");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5efe64c4-632f-4b5e-be5a-e0767dd53681", null, "Admin", "ADMIN" },
                    { "b7c47d8d-4ac0-4771-809c-a47893be27f2", null, "User", "USER" }
                });
        }
    }
}
