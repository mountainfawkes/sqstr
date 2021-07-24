using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sqstr.Solution.Migrations
{
    public partial class NomicsRootProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Roots",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "High",
                table: "Roots",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "High_Timestamp",
                table: "Roots",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Roots",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Roots",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Price_Date",
                table: "Roots",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Price_Timestamp",
                table: "Roots",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Roots",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Roots");

            migrationBuilder.DropColumn(
                name: "High",
                table: "Roots");

            migrationBuilder.DropColumn(
                name: "High_Timestamp",
                table: "Roots");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Roots");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Roots");

            migrationBuilder.DropColumn(
                name: "Price_Date",
                table: "Roots");

            migrationBuilder.DropColumn(
                name: "Price_Timestamp",
                table: "Roots");

            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Roots");
        }
    }
}
