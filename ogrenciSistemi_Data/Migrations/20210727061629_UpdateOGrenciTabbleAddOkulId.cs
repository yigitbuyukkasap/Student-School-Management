using Microsoft.EntityFrameworkCore.Migrations;

namespace ogrenciSistemi_Data.Migrations
{
    public partial class UpdateOGrenciTabbleAddOkulId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OkulId",
                table: "Ogrenci",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_OkulId",
                table: "Ogrenci",
                column: "OkulId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenci_Okul_OkulId",
                table: "Ogrenci",
                column: "OkulId",
                principalTable: "Okul",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_Okul_OkulId",
                table: "Ogrenci");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenci_OkulId",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "OkulId",
                table: "Ogrenci");
        }
    }
}
