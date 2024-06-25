using Microsoft.EntityFrameworkCore.Migrations;

namespace CoronaMap.Migrations
{
    public partial class createtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    alpha2code = table.Column<string>(nullable: true),
                    alpha3code = table.Column<string>(nullable: true),
                    latitude = table.Column<double>(nullable: true),
                    longitude = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iso_code = table.Column<string>(nullable: true),
                    continent = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    total_cases = table.Column<double>(nullable: true),
                    new_cases = table.Column<double>(nullable: true),
                    new_cases_smoothed = table.Column<double>(nullable: true),
                    total_deaths = table.Column<double>(nullable: true),
                    new_deaths = table.Column<double>(nullable: true),
                    new_deaths_smoothed = table.Column<double>(nullable: true),
                    total_cases_per_million = table.Column<double>(nullable: true),
                    new_cases_per_million = table.Column<double>(nullable: true),
                    new_cases_smoothed_per_million = table.Column<double>(nullable: true),
                    total_deaths_per_million = table.Column<double>(nullable: true),
                    new_deaths_per_million = table.Column<double>(nullable: true),
                    new_deaths_smoothed_per_million = table.Column<double>(nullable: true),
                    reproduction_rate = table.Column<double>(nullable: true),
                    icu_patients = table.Column<double>(nullable: true),
                    icu_patients_per_million = table.Column<double>(nullable: true),
                    hosp_patients = table.Column<double>(nullable: true),
                    hosp_patients_per_million = table.Column<double>(nullable: true),
                    weekly_icu_admissions = table.Column<double>(nullable: true),
                    weekly_icu_admissions_per_million = table.Column<double>(nullable: true),
                    weekly_hosp_admissions = table.Column<double>(nullable: true),
                    weekly_hosp_admissions_per_million = table.Column<double>(nullable: true),
                    total_tests = table.Column<double>(nullable: true),
                    new_tests = table.Column<double>(nullable: true),
                    total_tests_per_thousand = table.Column<double>(nullable: true),
                    new_tests_per_thousand = table.Column<double>(nullable: true),
                    new_tests_smoothed = table.Column<double>(nullable: true),
                    new_tests_smoothed_per_thousand = table.Column<double>(nullable: true),
                    tests_per_case = table.Column<double>(nullable: true),
                    positive_rate = table.Column<double>(nullable: true),
                    tests_units = table.Column<string>(nullable: true),
                    total_vaccinations = table.Column<double>(nullable: true),
                    total_vaccinations_per_hundred = table.Column<double>(nullable: true),
                    stringency_index = table.Column<double>(nullable: true),
                    population = table.Column<double>(nullable: true),
                    population_density = table.Column<double>(nullable: true),
                    median_age = table.Column<double>(nullable: true),
                    aged_65_older = table.Column<double>(nullable: true),
                    aged_70_older = table.Column<double>(nullable: true),
                    gdp_per_capita = table.Column<double>(nullable: true),
                    extreme_poverty = table.Column<double>(nullable: true),
                    cardiovasc_death_rate = table.Column<double>(nullable: true),
                    diabetes_prevalence = table.Column<double>(nullable: true),
                    female_smokers = table.Column<double>(nullable: true),
                    male_smokers = table.Column<double>(nullable: true),
                    handwashing_facilities = table.Column<double>(nullable: true),
                    hospital_beds_per_thousand = table.Column<double>(nullable: true),
                    life_expectancy = table.Column<double>(nullable: true),
                    human_development_index = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryDetails", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CountryDetails");
        }
    }
}
