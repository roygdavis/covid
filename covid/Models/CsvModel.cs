using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace covid.Models
{
    public class CsvModel
    {
        [Name("iso_code")]
        public string IsoCode { get; set; } // ISO 3166-1 alpha-3 – three-letter country codes International Organization for Standardization

        [Name("continent")]
        public string Continent { get; set; }// Continent of the geographical location Our World in Data

        [Name("location")]
        public string Location { get; set; }// Geographical location   Our World in Data

        [Name("date")]
        public DateTime Date { get; set; } // Date of observation Our World in Data

        [Name("total_cases")]
        public double? TotalCases { get; set; }// Total confirmed cases of COVID-19	European Centre for Disease Prevention and Control

        [Name("new_cases")]
        public double? NewCases { get; set; }// New confirmed cases of COVID-19	European Centre for Disease Prevention and Control

        [Name("new_cases_smoothed")]
        public double? NewCasesSmoothed { get; set; }// New confirmed cases of COVID-19 (7-day smoothed)	European Centre for Disease Prevention and Control

        [Name("total_deaths")]
        public double? TotalDeaths { get; set; }// Total deaths attributed to COVID-19	European Centre for Disease Prevention and Control

        [Name("new_deaths")]
        public double? NewDeaths { get; set; } // New deaths attributed to COVID-19	European Centre for Disease Prevention and Control

        [Name("new_deaths_smoothed")]
        public double? NewDeathsSmoothed { get; set; }// New deaths attributed to COVID-19 (7-day smoothed)	European Centre for Disease Prevention and Control

        [Name("total_cases_per_million")]
        public double? TotalCasesPerMillion { get; set; }// Total confirmed cases of COVID-19 per 1,000,000 people European Centre for Disease Prevention and Control

        [Name("new_cases_per_million")]
        public double? NewCasesPerMillion { get; set; } // New confirmed cases of COVID-19 per 1,000,000 people European Centre for Disease Prevention and Control

        [Name("new_cases_smoothed_per_million")]
        public double? NewCasesSmoothedPerMillion { get; set; }// New confirmed cases of COVID-19 (7-day smoothed) per 1,000,000 people European Centre for Disease Prevention and Control

        [Name("total_deaths_per_million")]
        public double? TotalDeathsPerMillion { get; set; }// Total deaths attributed to COVID-19 per 1,000,000 people European Centre for Disease Prevention and Control

        [Name("new_deaths_per_million")]
        public double? NewDeathsPerMillion { get; set; } // New deaths attributed to COVID-19 per 1,000,000 people European Centre for Disease Prevention and Control

        [Name("new_deaths_smoothed_per_million")]
        public double? NewDeathsSmoothedPerMillion { get; set; }// New deaths attributed to COVID-19 (7-day smoothed) per 1,000,000 people European Centre for Disease Prevention and Control

        [Name("total_tests")]
        public double? TotalTests { get; set; }// Total tests for COVID-19	National government reports

        [Name("new_tests")]
        public double? NewTests { get; set; }// New tests for COVID-19	National government reports

        [Name("new_tests_smoothed")]
        public double? NewTestsSmoothed { get; set; }// New tests for COVID-19 (7-day smoothed). For countries that don't report testing data on a daily basis, we assume that testing changed equally on a daily basis over any periods in which no data was reported. This produces a complete series of daily figures, which is then averaged over a rolling 7-day window	National government reports

        [Name("total_tests_per_thousand")]
        public double? TotalTestsPerThousand { get; set; }// Total tests for COVID-19 per 1,000 people National government reports

        [Name("new_tests_per_thousand")]
        public double? NewTestsPerThousand { get; set; }// New tests for COVID-19 per 1,000 people National government reports

        [Name("new_tests_smoothed_per_thousand")]
        public double? NewTestsSmoothedPerThousand { get; set; }// New tests for COVID-19 (7-day smoothed) per 1,000 people National government reports

        [Name("tests_per_case")]
        public double? TestsPerCase { get; set; }// Tests conducted per new confirmed case of COVID-19, given as a rolling 7-day average(this is the inverse of positive_rate) National government reports

        [Name("positive_rate")]
        public double? PositiveRate { get; set; }// The share of COVID-19 tests that are positive, given as a rolling 7-day average(this is the inverse of tests_per_case) National government reports

        [Name("tests_units")]
        public string TestsUnits { get; set; }// Units used by the location to report its testing data   National government reports

        [Name("stringency_index")]
        public double? StringencyIndex { get; set; }// Government Response Stringency Index: composite measure based on 9 response indicators including school closures, workplace closures, and travel bans, rescaled to a value from 0 to 100 (100 = strictest response)	Oxford COVID-19 Government Response Tracker, Blavatnik School of Government

        [Name("population")]
        public double? Population { get; set; }// Population in 2020	United Nations, Department of Economic and Social Affairs, Population Division, World Population Prospects: The 2019 Revision

        [Name("population_density")]
        public double? PopulationDensity { get; set; } // Number of people divided by land area, measured in square kilometers, most recent year available World Bank – World Development Indicators, sourced from Food and Agriculture Organization and World Bank estimates

        [Name("median_age")]
        public double? MedianAge { get; set; } //Median age of the population, UN projection for 2020	UN Population Division, World Population Prospects, 2017 Revision

        [Name("aged_65_older")]
        public double? Aged65Older { get; set; }// Share of the population that is 65 years and older, most recent year available  World Bank – World Development Indicators, based on age/sex distributions of United Nations Population Division's World Population Prospects: 2017 Revision

        [Name("aged_70_older")]
        public double? Aged70Older { get; set; }// Share of the population that is 70 years and older in 2015	United Nations, Department of Economic and Social Affairs, Population Division(2017), World Population Prospects: The 2017 Revision

        [Name("gdp_per_capita")]
        public double? GdpPerCapita { get; set; }// Gross domestic product at purchasing power parity(constant 2011 double?ernational dollars), most recent year available World Bank – World Development Indicators, source from World Bank, International Comparison Program database

        [Name("extreme_poverty")]
        public double? ExtremePoverty { get; set; }// Share of the population living in extreme poverty, most recent year available since 2010	World Bank – World Development Indicators, sourced from World Bank Development Research Group

        [Name("cardiovasc_death_rate")]
        public double? CardiovasculourDeathRate { get; set; }// Death rate from cardiovascular disease in 2017 (annual number of deaths per 100,000 people)	Global Burden of Disease Collaborative Network, Global Burden of Disease Study 2017 Results

        [Name("diabetes_prevalence")]
        public double? DiabetesPrevalence { get; set; }// Diabetes prevalence(% of population aged 20 to 79) in 2017	World Bank – World Development Indicators, sourced from International Diabetes Federation, Diabetes Atlas

        [Name("female_smokers")]
        public double? FemaleSmokers { get; set; }// Share of women who smoke, most recent year available World Bank – World Development Indicators, sourced from World Health Organization, Global Health Observatory Data Repository

        [Name("male_smokers")]
        public double? MaleSmokers { get; set; }// Share of men who smoke, most recent year available  World Bank – World Development Indicators, sourced from World Health Organization, Global Health Observatory Data Repository

        [Name("handwashing_facilities")]
        public double? HandwashingFacilities { get; set; }// Share of the population with basic handwashing facilities on premises, most recent year available United Nations Statistics Division

        [Name("hospital_beds_per_thousand")]
        public double? HospitalBedsPerThousand { get; set; }// Hospital beds per 1,000 people, most recent year available since 2010	OECD, Eurostat, World Bank, national government records and other sources

        [Name("life_expectancy")]
        public double? LifeExpectancy { get; set; }// Life expectancy at birth in 2019
    }
}