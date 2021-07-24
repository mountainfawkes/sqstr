using Microsoft.EntityFrameworkCore.Migrations;

namespace sqstr.Solution.Migrations
{
    public partial class RemoveDistances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistanceUnit",
                table: "Electricities");

            migrationBuilder.DropColumn(
                name: "DistanceValue",
                table: "Electricities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DistanceUnit",
                table: "Electricities",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DistanceValue",
                table: "Electricities",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
