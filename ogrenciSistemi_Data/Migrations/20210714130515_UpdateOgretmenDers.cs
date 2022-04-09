using Microsoft.EntityFrameworkCore.Migrations;

namespace ogrenciSistemi_Data.Migrations
{
    public partial class UpdateOgretmenDers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgretmenDers_Siniflar_SinifIarId",
                table: "OgretmenDers");

            migrationBuilder.DropIndex(
                name: "IX_OgretmenDers_SinifIarId",
                table: "OgretmenDers");

            migrationBuilder.DropColumn(
                name: "SinifIarId",
                table: "OgretmenDers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SinifIarId",
                table: "OgretmenDers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenDers_SinifIarId",
                table: "OgretmenDers",
                column: "SinifIarId");

            migrationBuilder.AddForeignKey(
                name: "FK_OgretmenDers_Siniflar_SinifIarId",
                table: "OgretmenDers",
                column: "SinifIarId",
                principalTable: "Siniflar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
