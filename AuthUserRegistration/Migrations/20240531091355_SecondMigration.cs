using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthUserRegistration.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1febbe9b-3af1-4ac7-b10d-ca097922b924", null, "admin", "admin" },
                    { "b70b11a0-2bd7-4fdf-a002-92e7ac8a2b75", null, "seller", "seller" },
                    { "c1d8ab0f-c769-4a5b-a45e-f8edd03017a6", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1febbe9b-3af1-4ac7-b10d-ca097922b924");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b70b11a0-2bd7-4fdf-a002-92e7ac8a2b75");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1d8ab0f-c769-4a5b-a45e-f8edd03017a6");
        }
    }
}
