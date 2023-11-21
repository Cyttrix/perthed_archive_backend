using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class removeruntime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a12eddd-be3c-46a9-b7f2-c333726be65f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3a60197-48be-4102-a8a0-457e79a5f0bd");

            migrationBuilder.DropColumn(
                name: "Runtime",
                table: "Media");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3785e60e-6e32-4cdb-928f-a86728d302b8", null, "User", "USER" },
                    { "fa6d02bf-e484-4975-b0d4-7b3e0764466f", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3785e60e-6e32-4cdb-928f-a86728d302b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa6d02bf-e484-4975-b0d4-7b3e0764466f");

            migrationBuilder.AddColumn<int>(
                name: "Runtime",
                table: "Media",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a12eddd-be3c-46a9-b7f2-c333726be65f", null, "User", "USER" },
                    { "a3a60197-48be-4102-a8a0-457e79a5f0bd", null, "Admin", "ADMIN" }
                });
        }
    }
}
