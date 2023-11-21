using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class userName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13c0468d-2191-48fd-8d94-60400b870b38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5c92b1c-101c-4d22-b082-7c88c40eb42d");

            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "Posts",
                type: "longtext",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "950b9413-1fd3-45f4-8f16-8bc54911d3c1", null, "Admin", "ADMIN" },
                    { "f76988d9-288d-4826-b59b-b7d8da2e4a2c", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "950b9413-1fd3-45f4-8f16-8bc54911d3c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f76988d9-288d-4826-b59b-b7d8da2e4a2c");

            migrationBuilder.DropColumn(
                name: "userName",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13c0468d-2191-48fd-8d94-60400b870b38", null, "User", "USER" },
                    { "c5c92b1c-101c-4d22-b082-7c88c40eb42d", null, "Admin", "ADMIN" }
                });
        }
    }
}
