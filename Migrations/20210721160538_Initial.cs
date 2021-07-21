using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sqstr.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Electricities",
                columns: table => new
                {
                    ElectricityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarbonG = table.Column<float>(type: "float", nullable: false),
                    CarbonLb = table.Column<float>(type: "float", nullable: false),
                    CarbonKg = table.Column<float>(type: "float", nullable: false),
                    CarbonMt = table.Column<float>(type: "float", nullable: false),
                    Country = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DistanceUnit = table.Column<float>(type: "float", nullable: false),
                    DistanceValue = table.Column<float>(type: "float", nullable: false),
                    ElectricityUnit = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ElectricityValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EstimatedAt = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    State = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Electricities", x => x.ElectricityId);
                });

            migrationBuilder.CreateTable(
                name: "Estimates",
                columns: table => new
                {
                    EstimateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InterfaceEstimateId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estimates", x => x.EstimateId);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarbonG = table.Column<float>(type: "float", nullable: false),
                    CarbonLb = table.Column<float>(type: "float", nullable: false),
                    CarbonKg = table.Column<float>(type: "float", nullable: false),
                    CarbonMt = table.Column<float>(type: "float", nullable: false),
                    DistanceUnit = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DistanceValue = table.Column<float>(type: "float", nullable: false),
                    EstimatedAt = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LegId = table.Column<int>(type: "int", nullable: false),
                    Passengers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                });

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    FuelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarbonG = table.Column<float>(type: "float", nullable: false),
                    CarbonLb = table.Column<float>(type: "float", nullable: false),
                    CarbonKg = table.Column<float>(type: "float", nullable: false),
                    CarbonMt = table.Column<float>(type: "float", nullable: false),
                    EstimatedAt = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FuelSourceType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FuelSourceUnit = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FuelSourceValue = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.FuelId);
                });

            migrationBuilder.CreateTable(
                name: "Legs",
                columns: table => new
                {
                    LegId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DepartureAirport_1 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DestinationAirport_1 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DepartureAirport_2 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DestinationAirport_2 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DepartureAirport_3 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DestinationAirport_3 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legs", x => x.LegId);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    PriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Currency = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LatestPrice = table.Column<double>(type: "double", nullable: false),
                    PriceDate = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.PriceId);
                });

            migrationBuilder.CreateTable(
                name: "SeedAirports",
                columns: table => new
                {
                    SeedAirportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IATA = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lat = table.Column<double>(type: "double", nullable: false),
                    Lon = table.Column<double>(type: "double", nullable: false),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeedAirports", x => x.SeedAirportId);
                });

            migrationBuilder.CreateTable(
                name: "SeedCountries",
                columns: table => new
                {
                    SeedCountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeedCountries", x => x.SeedCountryId);
                });

            migrationBuilder.CreateTable(
                name: "SeedFuels",
                columns: table => new
                {
                    SeedFuelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FuelSourceUnit = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeedFuels", x => x.SeedFuelId);
                });

            migrationBuilder.CreateTable(
                name: "SeedSubregions",
                columns: table => new
                {
                    SeedSubregionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeedSubregions", x => x.SeedSubregionId);
                });

            migrationBuilder.CreateTable(
                name: "SeedVehicles",
                columns: table => new
                {
                    SeedVehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Make = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    QueryId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeedVehicles", x => x.SeedVehicleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Electricities");

            migrationBuilder.DropTable(
                name: "Estimates");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropTable(
                name: "Legs");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "SeedAirports");

            migrationBuilder.DropTable(
                name: "SeedCountries");

            migrationBuilder.DropTable(
                name: "SeedFuels");

            migrationBuilder.DropTable(
                name: "SeedSubregions");

            migrationBuilder.DropTable(
                name: "SeedVehicles");
        }
    }
}
