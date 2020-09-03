using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace covid.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rows",
                columns: table => new
                {
                    IsoCode = table.Column<string>(nullable: false),
                    Continent = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    TotalCases = table.Column<double>(nullable: true),
                    NewCases = table.Column<double>(nullable: true),
                    NewCasesSmoothed = table.Column<double>(nullable: true),
                    TotalDeaths = table.Column<double>(nullable: true),
                    NewDeaths = table.Column<double>(nullable: true),
                    NewDeathsSmoothed = table.Column<double>(nullable: true),
                    TotalCasesPerMillion = table.Column<double>(nullable: true),
                    NewCasesPerMillion = table.Column<double>(nullable: true),
                    NewCasesSmoothedPerMillion = table.Column<double>(nullable: true),
                    TotalDeathsPerMillion = table.Column<double>(nullable: true),
                    NewDeathsPerMillion = table.Column<double>(nullable: true),
                    NewDeathsSmoothedPerMillion = table.Column<double>(nullable: true),
                    TotalTests = table.Column<double>(nullable: true),
                    NewTests = table.Column<double>(nullable: true),
                    NewTestsSmoothed = table.Column<double>(nullable: true),
                    TotalTestsPerThousand = table.Column<double>(nullable: true),
                    NewTestsPerThousand = table.Column<double>(nullable: true),
                    NewTestsSmoothedPerThousand = table.Column<double>(nullable: true),
                    TestsPerCase = table.Column<double>(nullable: true),
                    PositiveRate = table.Column<double>(nullable: true),
                    TestsUnits = table.Column<string>(nullable: true),
                    StringencyIndex = table.Column<double>(nullable: true),
                    Population = table.Column<double>(nullable: true),
                    PopulationDensity = table.Column<double>(nullable: true),
                    MedianAge = table.Column<double>(nullable: true),
                    Aged65Older = table.Column<double>(nullable: true),
                    Aged70Older = table.Column<double>(nullable: true),
                    GdpPerCapita = table.Column<double>(nullable: true),
                    ExtremePoverty = table.Column<double>(nullable: true),
                    CardiovasculourDeathRate = table.Column<double>(nullable: true),
                    DiabetesPrevalence = table.Column<double>(nullable: true),
                    FemaleSmokers = table.Column<double>(nullable: true),
                    MaleSmokers = table.Column<double>(nullable: true),
                    HandwashingFacilities = table.Column<double>(nullable: true),
                    HospitalBedsPerThousand = table.Column<double>(nullable: true),
                    LifeExpectancy = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rows", x => new { x.IsoCode, x.Continent, x.Location, x.Date });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rows");
        }
    }
}
