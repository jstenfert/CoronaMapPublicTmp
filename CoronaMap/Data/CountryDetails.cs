using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace CoronaMap.Data
{
    public class CountryDetails
    {
        public int ID { get; set; }
        public int iso_code { get; set; }
        public string continent { get; set; }
        public string location { get; set; }
        public string last_updated_date { get; set; }
        public double? total_cases { get; set; }
        public double? new_cases { get; set; }
        public double? new_cases_smoothed { get; set; }
        public double? total_deaths { get; set; }
        public double? new_deaths { get; set; }
        public double? new_deaths_smoothed { get; set; }
        public double? total_cases_per_million { get; set; }
        public double? new_cases_per_million { get; set; }
        public double? new_cases_smoothed_per_million { get; set; }
        public double? total_deaths_per_million { get; set; }
        public double? new_deaths_per_million { get; set; }
        public double? new_deaths_smoothed_per_million { get; set; }
        public double? reproduction_rate { get; set; }
        public double? icu_patients { get; set; }
        public double? icu_patients_per_million { get; set; }
        public double? hosp_patients { get; set; }
        public double? hosp_patients_per_million { get; set; }
        public double? weekly_icu_admissions { get; set; }
        public double? weekly_icu_admissions_per_million { get; set; }
        public double? weekly_hosp_admissions { get; set; }
        public double? weekly_hosp_admissions_per_million { get; set; }
        public double? total_tests { get; set; }
        public double? new_tests { get; set; }
        public double? total_tests_per_thousand { get; set; }
        public double? new_tests_per_thousand { get; set; }
        public double? new_tests_smoothed { get; set; }
        public double? new_tests_smoothed_per_thousand { get; set; }
        public double? positive_rate { get; set; }
        public double? tests_per_case { get; set; }
        public string tests_units { get; set; }
        public double? total_vaccinations { get; set; }
        public double? people_vaccinated { get; set; }
        public double? people_fully_vaccinated { get; set; }
        public double? total_boosters { get; set; }
        public double? new_vaccinations { get; set; }
        public double? new_vaccinations_smoothed { get; set; }
        public double? total_vaccinations_per_hundred { get; set; }
        public double? people_vaccinated_per_hundred { get; set; }
        public double? people_fully_vaccinated_per_hundred { get; set; }
        public double? total_boosters_per_hundred { get; set; }
        public double? new_vaccinations_smoothed_per_million { get; set; }
        public double? new_people_vaccinated_smoothed { get; set; }
        public double? new_people_vaccinated_smoothed_per_hundred { get; set; }
        public double? stringency_index { get; set; }
        public double? population_density { get; set; }
        public double? median_age { get; set; }
        public double? aged_65_older { get; set; }
        public double? aged_70_older { get; set; }
        public double? gdp_per_capita { get; set; }
        public double? extreme_poverty { get; set; }
        public double? cardiovasc_death_rate { get; set; }
        public double? diabetes_prevalence { get; set; }
        public double? female_smokers { get; set; }
        public double? male_smokers { get; set; }
        public double? handwashing_facilities { get; set; }
        public double? hospital_beds_per_thousand { get; set; }
        public double? life_expectancy { get; set; }
        public double? human_development_index { get; set; }
        public double? population { get; set; }
        public double? excess_mortality_cumulative_absolute { get; set; }
        public double? excess_mortality_cumulative { get; set; }
        public double? excess_mortality { get; set; }
        public double? excess_mortality_cumulative_per_million { get; set; }




        //public int ID { get; set; }
        //public string iso_code { get; set; }
        //public string continent { get; set; }
        //public string location { get; set; }
        //public string date { get; set; }
        //public double? total_cases { get; set; }
        //public double? new_cases { get; set; }
        //public double? new_cases_smoothed { get; set; }
        //public double? total_deaths { get; set; }
        //public double? new_deaths { get; set; }
        //public double? new_deaths_smoothed { get; set; }
        //public double? total_cases_per_million { get; set; }
        //public double? new_cases_per_million { get; set; }
        //public double? new_cases_smoothed_per_million { get; set; }
        //public double? total_deaths_per_million { get; set; }
        //public double? new_deaths_per_million { get; set; }
        //public double? new_deaths_smoothed_per_million { get; set; }
        //public double? reproduction_rate { get; set; }
        //public double? icu_patients { get; set; }
        //public double? icu_patients_per_million { get; set; }
        //public double? hosp_patients { get; set; }
        //public double? hosp_patients_per_million { get; set; }
        //public double? weekly_icu_admissions { get; set; }
        //public double? weekly_icu_admissions_per_million { get; set; }
        //public double? weekly_hosp_admissions { get; set; }
        //public double? weekly_hosp_admissions_per_million { get; set; }
        //public double? total_tests { get; set; }
        //public double? new_tests { get; set; }
        //public double? total_tests_per_thousand { get; set; }
        //public double? new_tests_per_thousand { get; set; }
        //public double? new_tests_smoothed { get; set; }
        //public double? new_tests_smoothed_per_thousand { get; set; }
        //public double? tests_per_case { get; set; }
        //public double? positive_rate { get; set; }
        //public string tests_units { get; set; }
        //public double? total_vaccinations { get; set; }
        //public double? total_vaccinations_per_hundred { get; set; }
        //public double? stringency_index { get; set; }
        //public double? population { get; set; }
        //public double? population_density { get; set; }
        //public double? median_age { get; set; }
        //public double? aged_65_older { get; set; }
        //public double? aged_70_older { get; set; }
        //public double? gdp_per_capita { get; set; }
        //public double? extreme_poverty { get; set; }
        //public double? cardiovasc_death_rate { get; set; }
        //public double? diabetes_prevalence { get; set; }
        //public double? female_smokers { get; set; }
        //public double? male_smokers { get; set; }
        //public double? handwashing_facilities { get; set; }
        //public double? hospital_beds_per_thousand { get; set; }
        //public double? life_expectancy { get; set; }
        //public double? human_development_index { get; set; }




        public static List<CountryDetails> ListFromJson(string json) => JsonConvert.DeserializeObject<List<CountryDetails>>(json);
        public static CountryDetails FromJson(string json) => JsonConvert.DeserializeObject<CountryDetails>(json);

        public CountryDetails()
        { }

        public CountryDetails(DataRow row)
        {
            try { ID = Convert.ToInt32(row["ID"]); } catch { }
            try { iso_code = Convert.ToInt32(row["iso_code"]); } catch { }
            try { continent = row["continent"].ToString(); } catch { }
            try { location = row["location"].ToString(); } catch { }
            try { last_updated_date = row["last_updated_date"].ToString(); } catch { }
            try { total_cases = Convert.ToDouble(row["total_cases"]); } catch { }
            try { new_cases = Convert.ToDouble(row["new_cases"]); } catch { }
            try { new_cases_smoothed = Convert.ToDouble(row["new_cases_smoothed"]); } catch { }
            try { total_deaths = Convert.ToDouble(row["total_deaths"]); } catch { }
            try { new_deaths = Convert.ToDouble(row["new_deaths"]); } catch { }
            try { new_deaths_smoothed = Convert.ToDouble(row["new_deaths_smoothed"]); } catch { }
            try { total_cases_per_million = Convert.ToDouble(row["total_cases_per_million"]); } catch { }
            try { new_cases_per_million = Convert.ToDouble(row["new_cases_per_million"]); } catch { }
            try { new_cases_smoothed_per_million = Convert.ToDouble(row["new_cases_smoothed_per_million"]); } catch { }
            try { total_deaths_per_million = Convert.ToDouble(row["total_deaths_per_million"]); } catch { }
            try { new_deaths_per_million = Convert.ToDouble(row["new_deaths_per_million"]); } catch { }
            try { new_deaths_smoothed_per_million = Convert.ToDouble(row["new_deaths_smoothed_per_million"]); } catch { }
            try { reproduction_rate = Convert.ToDouble(row["reproduction_rate"]); } catch { }
            try { icu_patients = Convert.ToDouble(row["icu_patients"]); } catch { }
            try { icu_patients_per_million = Convert.ToDouble(row["icu_patients_per_million"]); } catch { }
            try { hosp_patients = Convert.ToDouble(row["hosp_patients"]); } catch { }
            try { hosp_patients_per_million = Convert.ToDouble(row["hosp_patients_per_million"]); } catch { }
            try { weekly_icu_admissions = Convert.ToDouble(row["weekly_icu_admissions"]); } catch { }
            try { weekly_icu_admissions_per_million = Convert.ToDouble(row["weekly_icu_admissions_per_million"]); } catch { }
            try { weekly_hosp_admissions = Convert.ToDouble(row["weekly_hosp_admissions"]); } catch { }
            try { weekly_hosp_admissions_per_million = Convert.ToDouble(row["weekly_hosp_admissions_per_million"]); } catch { }
            try { total_tests = Convert.ToDouble(row["total_tests"]); } catch { }
            try { new_tests = Convert.ToDouble(row["new_tests"]); } catch { }
            try { total_tests_per_thousand = Convert.ToDouble(row["total_tests_per_thousand"]); } catch { }
            try { new_tests_per_thousand = Convert.ToDouble(row["new_tests_per_thousand"]); } catch { }
            try { new_tests_smoothed = Convert.ToDouble(row["new_tests_smoothed"]); } catch { }
            try { new_tests_smoothed_per_thousand = Convert.ToDouble(row["new_tests_smoothed_per_thousand"]); } catch { }
            try { positive_rate = Convert.ToDouble(row["positive_rate"]); } catch { }
            try { tests_per_case = Convert.ToDouble(row["tests_per_case"]); } catch { }
            try { tests_units = row["tests_units"].ToString(); } catch { }
            try { total_vaccinations = Convert.ToDouble(row["total_vaccinationss"]); } catch { }
            try { people_vaccinated = Convert.ToDouble(row["people_vaccinated"]); } catch { }
            try { people_fully_vaccinated = Convert.ToDouble(row["people_fully_vaccinated"]); } catch { }
            try { total_boosters = Convert.ToDouble(row["total_boosters"]); } catch { }
            try { new_vaccinations = Convert.ToDouble(row["new_vaccinations"]); } catch { }
            try { new_vaccinations_smoothed = Convert.ToDouble(row["new_vaccinations_smoothed"]); } catch { }
            try { total_vaccinations_per_hundred = Convert.ToDouble(row["total_vaccinations_per_hundred"]); } catch { }
            try { people_vaccinated_per_hundred = Convert.ToDouble(row["people_vaccinated_per_hundred"]); } catch { }
            try { people_fully_vaccinated_per_hundred = Convert.ToDouble(row["people_fully_vaccinated_per_hundred"]); } catch { }
            try { total_boosters_per_hundred = Convert.ToDouble(row["total_boosters_per_hundred"]); } catch { }
            try { new_vaccinations_smoothed_per_million = Convert.ToDouble(row["new_vaccinations_smoothed_per_million"]); } catch { }
            try { new_people_vaccinated_smoothed = Convert.ToDouble(row["new_people_vaccinated_smoothed"]); } catch { }
            try { new_people_vaccinated_smoothed_per_hundred = Convert.ToDouble(row["new_people_vaccinated_smoothed_per_hundred"]); } catch { }
            try { stringency_index = Convert.ToDouble(row["stringency_index"]); } catch { }
            try { population_density = Convert.ToDouble(row["population_density"]); } catch { }
            try { median_age = Convert.ToDouble(row["median_age"]); } catch { }
            try { aged_65_older = Convert.ToDouble(row["aged_65_older"]); } catch { }
            try { aged_70_older = Convert.ToDouble(row["aged_70_older"]); } catch { }
            try { gdp_per_capita = Convert.ToDouble(row["gdp_per_capita"]); } catch { }
            try { extreme_poverty = Convert.ToDouble(row["extreme_poverty"]); } catch { }
            try { cardiovasc_death_rate = Convert.ToDouble(row["cardiovasc_death_rate"]); } catch { }
            try { diabetes_prevalence = Convert.ToDouble(row["diabetes_prevalence"]); } catch { }
            try { female_smokers = Convert.ToDouble(row["female_smokers"]); } catch { }
            try { male_smokers = Convert.ToDouble(row["male_smokers"]); } catch { }
            try { handwashing_facilities = Convert.ToDouble(row["handwashing_facilities"]); } catch { }
            try { hospital_beds_per_thousand = Convert.ToDouble(row["hospital_beds_per_thousand"]); } catch { }
            try { life_expectancy = Convert.ToDouble(row["life_expectancy"]); } catch { }
            try { human_development_index = Convert.ToDouble(row["human_development_index"]); } catch { }
            try { population = Convert.ToDouble(row["population"]); } catch { }
            try { excess_mortality_cumulative_absolute = Convert.ToDouble(row["excess_mortality_cumulative_absolute"]); } catch { }
            try { excess_mortality_cumulative = Convert.ToDouble(row["excess_mortality_cumulative"]); } catch { }
            try { excess_mortality = Convert.ToDouble(row["excess_mortality"]); } catch { }
            try { excess_mortality_cumulative_per_million = Convert.ToDouble(row["excess_mortality_cumulative_per_million"]); } catch { }

        }
    }
}