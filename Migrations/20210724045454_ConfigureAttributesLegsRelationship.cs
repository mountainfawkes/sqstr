using Microsoft.EntityFrameworkCore.Migrations;

namespace sqstr.Solution.Migrations
{
    public partial class ConfigureAttributesLegsRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Legs_Attributes_AttributesId",
                table: "Legs");

            migrationBuilder.AlterColumn<int>(
                name: "AttributesId",
                table: "Legs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Legs_Attributes_AttributesId",
                table: "Legs",
                column: "AttributesId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Legs_Attributes_AttributesId",
                table: "Legs");

            migrationBuilder.AlterColumn<int>(
                name: "AttributesId",
                table: "Legs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Legs_Attributes_AttributesId",
                table: "Legs",
                column: "AttributesId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
