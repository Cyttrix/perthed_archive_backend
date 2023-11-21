using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CoverImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1149e6c-5f5e-4b0f-a4a0-53cb2eae3ad0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea6c0922-ad5d-459b-85d0-16a015c8982f");

            migrationBuilder.AddColumn<string>(
                name: "CoverImg",
                table: "Posts",
                type: "longtext",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5efe64c4-632f-4b5e-be5a-e0767dd53681", null, "Admin", "ADMIN" },
                    { "b7c47d8d-4ac0-4771-809c-a47893be27f2", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5efe64c4-632f-4b5e-be5a-e0767dd53681");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7c47d8d-4ac0-4771-809c-a47893be27f2");

            migrationBuilder.DropColumn(
                name: "CoverImg",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1149e6c-5f5e-4b0f-a4a0-53cb2eae3ad0", null, "Admin", "ADMIN" },
                    { "ea6c0922-ad5d-459b-85d0-16a015c8982f", null, "User", "USER" }
                });
        }
    }
}
