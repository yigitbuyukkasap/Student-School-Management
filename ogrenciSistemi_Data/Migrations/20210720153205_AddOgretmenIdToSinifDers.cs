using Microsoft.EntityFrameworkCore.Migrations;

namespace ogrenciSistemi_Data.Migrations
{
    public partial class AddOgretmenIdToSinifDers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OgretmenId",
                table: "SinifDers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SinifDers_OgretmenId",
                table: "SinifDers",
                column: "OgretmenId");

            migrationBuilder.AddForeignKey(
                name: "FK_SinifDers_AspNetUsers_OgretmenId",
                table: "SinifDers",
                column: "OgretmenId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinifDers_AspNetUsers_OgretmenId",
                table: "SinifDers");

            migrationBuilder.DropIndex(
                name: "IX_SinifDers_OgretmenId",
                table: "SinifDers");

            migrationBuilder.DropColumn(
                name: "OgretmenId",
                table: "SinifDers");
        }
    }
}
