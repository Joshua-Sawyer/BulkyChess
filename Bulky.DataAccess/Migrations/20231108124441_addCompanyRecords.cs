using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCompanyRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "County", "Name", "PhoneNumber", "PostCode", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Lichfield", "Staffs", "Chess and Bridge", "22222222", "ab544ba", "123 Main Street" },
                    { 2, "Bolton", "Lancs", "Chess for All", "2345678", "bo5474x", "43 Old Road" },
                    { 3, "York", "Yorks", "The Games Shop", "34623462", "yo873us", "3 Kings Road" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
