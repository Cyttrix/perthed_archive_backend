using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RuntimeAllowNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21b0046b-1d9e-40f2-9d38-f0cf82ddbeec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9a1742f-2031-4e39-a8f3-303c1296f83c");

            migrationBuilder.AlterColumn<string>(
                name: "Runtime",
                table: "Media",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8f86b251-09e9-4741-a20a-459736ead7ab", null, "Admin", "ADMIN" },
                    { "d441c009-636e-47f5-8a8c-7e7016e8031b", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f86b251-09e9-4741-a20a-459736ead7ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d441c009-636e-47f5-8a8c-7e7016e8031b");

            migrationBuilder.AlterColumn<string>(
                name: "Runtime",
                table: "Media",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21b0046b-1d9e-40f2-9d38-f0cf82ddbeec", null, "Admin", "ADMIN" },
                    { "f9a1742f-2031-4e39-a8f3-303c1296f83c", null, "User", "USER" }
                });
        }
    }
}
