using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addruntimeasint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "31cf52ca-d6f5-41bb-97f7-6d8535d72785", null, "Admin", "ADMIN" },
                    { "3f5f3572-edb2-4144-bf4e-3b4dc6658857", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31cf52ca-d6f5-41bb-97f7-6d8535d72785");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f5f3572-edb2-4144-bf4e-3b4dc6658857");

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
    }
}
