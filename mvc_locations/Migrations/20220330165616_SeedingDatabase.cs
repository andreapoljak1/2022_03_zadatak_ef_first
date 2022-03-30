using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_locations.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 1, "+385", "Hrvatska", "Croatia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 2, "+33", "Francuska", "France" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 3, "+55", "Brazil", "Brazil" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "id", "city_name", "country_id", "latitude", "longitude" },
                values: new object[,]
                {
                    { 1, "Đakovo", 1, 45.3100m, 18.4098m },
                    { 2, "Split", 1, 43.5147m, 16.4435m },
                    { 3, "São Paulo", 3, 23.5558m, 46.6396m },
                    { 4, "Rio de Janeiro", 3, 22.9068m, 43.1729m },
                    { 5, "Marseille", 2, 43.2965m, 5.3698m },
                    { 6, "Lille", 2, 50.6292m, 3.0573m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
