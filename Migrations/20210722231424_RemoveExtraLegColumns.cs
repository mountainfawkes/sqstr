using Microsoft.EntityFrameworkCore.Migrations;

namespace sqstr.Solution.Migrations
{
    public partial class RemoveExtraLegColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartureAirport_1",
                table: "Legs");

            migrationBuilder.DropColumn(
                name: "DepartureAirport_2",
                table: "Legs");

            migrationBuilder.DropColumn(
                name: "DepartureAirport_3",
                table: "Legs");

            migrationBuilder.DropColumn(
                name: "DestinationAirport_1",
                table: "Legs");

            migrationBuilder.DropColumn(
                name: "LegId",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "DestinationAirport_3",
                table: "Legs",
                newName: "DestinationAirport");

            migrationBuilder.RenameColumn(
                name: "DestinationAirport_2",
                table: "Legs",
                newName: "DepartureAirport");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DestinationAirport",
                table: "Legs",
                newName: "DestinationAirport_3");

            migrationBuilder.RenameColumn(
                name: "DepartureAirport",
                table: "Legs",
                newName: "DestinationAirport_2");

            migrationBuilder.AddColumn<string>(
                name: "DepartureAirport_1",
                table: "Legs",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartureAirport_2",
                table: "Legs",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartureAirport_3",
                table: "Legs",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationAirport_1",
                table: "Legs",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LegId",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
