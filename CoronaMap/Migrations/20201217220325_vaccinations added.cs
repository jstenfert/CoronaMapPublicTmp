using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaMap.Migrations
{
    public partial class vaccinationsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "total_vaccinations",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "total_vaccinations_per_hundred",
                table: "CountryDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "total_vaccinations",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "total_vaccinations_per_hundred",
                table: "CountryDetails");
        }
    }
}
