using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sqstr.Solution.Migrations
{
    public partial class EstimatesRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstimateId",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Legs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstimateId",
                table: "Fuels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstimateId",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstimateId",
                table: "Electricities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    ShippingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarbonG = table.Column<float>(type: "float", nullable: false),
                    CarbonLb = table.Column<float>(type: "float", nullable: false),
                    CarbonKg = table.Column<float>(type: "float", nullable: false),
                    CarbonMt = table.Column<float>(type: "float", nullable: false),
                    DistanceUnit = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DistanceValue = table.Column<float>(type: "float", nullable: false),
                    EstimatedAt = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    WeightUnit = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    WeightValue = table.Column<float>(type: "float", nullable: false),
                    EstimateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.ShippingId);
                    table.ForeignKey(
                        name: "FK_Shipping_Estimates_EstimateId",
                        column: x => x.EstimateId,
                        principalTable: "Estimates",
                        principalColumn: "EstimateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarbonG = table.Column<float>(type: "float", nullable: false),
                    CarbonLb = table.Column<float>(type: "float", nullable: false),
                    CarbonKg = table.Column<float>(type: "float", nullable: false),
                    CarbonMt = table.Column<float>(type: "float", nullable: false),
                    DistanceUnit = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DistanceValue = table.Column<float>(type: "float", nullable: false),
                    EstimatedAt = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    VehicleMake = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    VehicleModel = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    VehicleModelId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    VehicleYear = table.Column<int>(type: "int", nullable: false),
                    EstimateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicle_Estimates_EstimateId",
                        column: x => x.EstimateId,
                        principalTable: "Estimates",
                        principalColumn: "EstimateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prices_EstimateId",
                table: "Prices",
                column: "EstimateId");

            migrationBuilder.CreateIndex(
                name: "IX_Legs_FlightId",
                table: "Legs",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Fuels_EstimateId",
                table: "Fuels",
                column: "EstimateId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_EstimateId",
                table: "Flights",
                column: "EstimateId");

            migrationBuilder.CreateIndex(
                name: "IX_Electricities_EstimateId",
                table: "Electricities",
                column: "EstimateId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_EstimateId",
                table: "Shipping",
                column: "EstimateId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_EstimateId",
                table: "Vehicle",
                column: "EstimateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Electricities_Estimates_EstimateId",
                table: "Electricities",
                column: "EstimateId",
                principalTable: "Estimates",
                principalColumn: "EstimateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Estimates_EstimateId",
                table: "Flights",
                column: "EstimateId",
                principalTable: "Estimates",
                principalColumn: "EstimateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fuels_Estimates_EstimateId",
                table: "Fuels",
                column: "EstimateId",
                principalTable: "Estimates",
                principalColumn: "EstimateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Legs_Flights_FlightId",
                table: "Legs",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Estimates_EstimateId",
                table: "Prices",
                column: "EstimateId",
                principalTable: "Estimates",
                principalColumn: "EstimateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Electricities_Estimates_EstimateId",
                table: "Electricities");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Estimates_EstimateId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Fuels_Estimates_EstimateId",
                table: "Fuels");

            migrationBuilder.DropForeignKey(
                name: "FK_Legs_Flights_FlightId",
                table: "Legs");

            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Estimates_EstimateId",
                table: "Prices");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Prices_EstimateId",
                table: "Prices");

            migrationBuilder.DropIndex(
                name: "IX_Legs_FlightId",
                table: "Legs");

            migrationBuilder.DropIndex(
                name: "IX_Fuels_EstimateId",
                table: "Fuels");

            migrationBuilder.DropIndex(
                name: "IX_Flights_EstimateId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Electricities_EstimateId",
                table: "Electricities");

            migrationBuilder.DropColumn(
                name: "EstimateId",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Legs");

            migrationBuilder.DropColumn(
                name: "EstimateId",
                table: "Fuels");

            migrationBuilder.DropColumn(
                name: "EstimateId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "EstimateId",
                table: "Electricities");
        }
    }
}
