using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class MediaTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "950b9413-1fd3-45f4-8f16-8bc54911d3c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f76988d9-288d-4826-b59b-b7d8da2e4a2c");

            migrationBuilder.AddColumn<string>(
                name: "MediaTitle",
                table: "Posts",
                type: "longtext",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1149e6c-5f5e-4b0f-a4a0-53cb2eae3ad0", null, "Admin", "ADMIN" },
                    { "ea6c0922-ad5d-459b-85d0-16a015c8982f", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1149e6c-5f5e-4b0f-a4a0-53cb2eae3ad0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea6c0922-ad5d-459b-85d0-16a015c8982f");

            migrationBuilder.DropColumn(
                name: "MediaTitle",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "950b9413-1fd3-45f4-8f16-8bc54911d3c1", null, "Admin", "ADMIN" },
                    { "f76988d9-288d-4826-b59b-b7d8da2e4a2c", null, "User", "USER" }
                });
        }
    }
}
