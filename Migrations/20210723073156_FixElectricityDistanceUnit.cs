using Microsoft.EntityFrameworkCore.Migrations;

namespace sqstr.Solution.Migrations
{
    public partial class FixElectricityDistanceUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DistanceUnit",
                table: "Electricities",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "DistanceUnit",
                table: "Electricities",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);
        }
    }
}
