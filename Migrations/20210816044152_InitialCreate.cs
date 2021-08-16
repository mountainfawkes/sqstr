using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sqstr.Solution.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carbon_G = table.Column<long>(type: "bigint", nullable: false),
                    Carbon_Lb = table.Column<double>(type: "float", nullable: false),
                    Carbon_Kg = table.Column<double>(type: "float", nullable: false),
                    Carbon_Mt = table.Column<double>(type: "float", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distance_Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distance_Value = table.Column<double>(type: "float", nullable: false),
                    Estimated_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Electricity_Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Electricity_Value = table.Column<double>(type: "float", nullable: false),
                    Fuel_Source_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuel_Source_Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuel_Source_Value = table.Column<double>(type: "float", nullable: false),
                    Passengers = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transport_Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicle_Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicle_Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicle_Year = table.Column<int>(type: "int", nullable: false),
                    Weight_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight_Unit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    PriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatestPrice = table.Column<double>(type: "float", nullable: false),
                    PriceDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.PriceId);
                });

            migrationBuilder.CreateTable(
                name: "Data",
                columns: table => new
                {
                    DataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttributesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data", x => x.DataId);
                    table.ForeignKey(
                        name: "FK_Data_Attributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Legs",
                columns: table => new
                {
                    LegsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Departure_Airport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination_Airport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttributesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legs", x => x.LegsId);
                    table.ForeignKey(
                        name: "FK_Legs_Attributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roots",
                columns: table => new
                {
                    RootId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataId = table.Column<int>(type: "int", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price_Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    High = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    High_Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roots", x => x.RootId);
                    table.ForeignKey(
                        name: "FK_Roots_Data_DataId",
                        column: x => x.DataId,
                        principalTable: "Data",
                        principalColumn: "DataId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Data_AttributesId",
                table: "Data",
                column: "AttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_Legs_AttributesId",
                table: "Legs",
                column: "AttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_Roots_DataId",
                table: "Roots",
                column: "DataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Legs");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Roots");

            migrationBuilder.DropTable(
                name: "Data");

            migrationBuilder.DropTable(
                name: "Attributes");
        }
    }
}
