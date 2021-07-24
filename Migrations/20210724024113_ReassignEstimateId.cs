using Microsoft.EntityFrameworkCore.Migrations;

namespace sqstr.Solution.Migrations
{
    public partial class ReassignEstimateId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InterfaceEstimateId",
                table: "Estimates",
                newName: "Id");

            migrationBuilder.AlterColumn<float>(
                name: "ElectricityValue",
                table: "Electricities",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Estimates",
                newName: "InterfaceEstimateId");

            migrationBuilder.AlterColumn<string>(
                name: "ElectricityValue",
                table: "Electricities",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float");
        }
    }
}
