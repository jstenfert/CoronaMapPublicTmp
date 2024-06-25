using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaMap.Migrations
{
    public partial class updateboosters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "CountryDetails");

            migrationBuilder.AlterColumn<int>(
                name: "iso_code",
                table: "CountryDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "excess_mortality",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "excess_mortality_cumulative",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "excess_mortality_cumulative_absolute",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "excess_mortality_cumulative_per_million",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "last_updated_date",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "new_people_vaccinated_smoothed",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "new_people_vaccinated_smoothed_per_hundred",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "new_vaccinations",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "new_vaccinations_smoothed",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "new_vaccinations_smoothed_per_million",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "people_fully_vaccinated",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "people_fully_vaccinated_per_hundred",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "people_vaccinated",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "people_vaccinated_per_hundred",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "total_boosters",
                table: "CountryDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "total_boosters_per_hundred",
                table: "CountryDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "excess_mortality",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "excess_mortality_cumulative",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "excess_mortality_cumulative_absolute",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "excess_mortality_cumulative_per_million",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "last_updated_date",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "new_people_vaccinated_smoothed",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "new_people_vaccinated_smoothed_per_hundred",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "new_vaccinations",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "new_vaccinations_smoothed",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "new_vaccinations_smoothed_per_million",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "people_fully_vaccinated",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "people_fully_vaccinated_per_hundred",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "people_vaccinated",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "people_vaccinated_per_hundred",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "total_boosters",
                table: "CountryDetails");

            migrationBuilder.DropColumn(
                name: "total_boosters_per_hundred",
                table: "CountryDetails");

            migrationBuilder.AlterColumn<string>(
                name: "iso_code",
                table: "CountryDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "date",
                table: "CountryDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
