using Microsoft.EntityFrameworkCore.Migrations;

namespace sqstr.Solution.Migrations
{
    public partial class RemoveFKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attributes_Data_DataId",
                table: "Attributes");

            migrationBuilder.DropForeignKey(
                name: "FK_Data_Roots_RootId",
                table: "Data");

            migrationBuilder.DropForeignKey(
                name: "FK_Legs_Attributes_AttributesId",
                table: "Legs");

            migrationBuilder.DropIndex(
                name: "IX_Data_RootId",
                table: "Data");

            migrationBuilder.DropIndex(
                name: "IX_Attributes_DataId",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "RootId",
                table: "Data");

            migrationBuilder.DropColumn(
                name: "DataId",
                table: "Attributes");

            migrationBuilder.AddColumn<int>(
                name: "DataId",
                table: "Roots",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AttributesId",
                table: "Legs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AttributesId",
                table: "Data",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roots_DataId",
                table: "Roots",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_Data_AttributesId",
                table: "Data",
                column: "AttributesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Data_Attributes_AttributesId",
                table: "Data",
                column: "AttributesId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Legs_Attributes_AttributesId",
                table: "Legs",
                column: "AttributesId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roots_Data_DataId",
                table: "Roots",
                column: "DataId",
                principalTable: "Data",
                principalColumn: "DataId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Data_Attributes_AttributesId",
                table: "Data");

            migrationBuilder.DropForeignKey(
                name: "FK_Legs_Attributes_AttributesId",
                table: "Legs");

            migrationBuilder.DropForeignKey(
                name: "FK_Roots_Data_DataId",
                table: "Roots");

            migrationBuilder.DropIndex(
                name: "IX_Roots_DataId",
                table: "Roots");

            migrationBuilder.DropIndex(
                name: "IX_Data_AttributesId",
                table: "Data");

            migrationBuilder.DropColumn(
                name: "DataId",
                table: "Roots");

            migrationBuilder.DropColumn(
                name: "AttributesId",
                table: "Data");

            migrationBuilder.AlterColumn<int>(
                name: "AttributesId",
                table: "Legs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RootId",
                table: "Data",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataId",
                table: "Attributes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Data_RootId",
                table: "Data",
                column: "RootId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_DataId",
                table: "Attributes",
                column: "DataId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Attributes_Data_DataId",
                table: "Attributes",
                column: "DataId",
                principalTable: "Data",
                principalColumn: "DataId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Data_Roots_RootId",
                table: "Data",
                column: "RootId",
                principalTable: "Roots",
                principalColumn: "RootId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Legs_Attributes_AttributesId",
                table: "Legs",
                column: "AttributesId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
