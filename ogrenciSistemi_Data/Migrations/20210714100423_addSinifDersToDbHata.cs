using Microsoft.EntityFrameworkCore.Migrations;

namespace ogrenciSistemi_Data.Migrations
{
    public partial class addSinifDersToDbHata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiniflarId",
                table: "SinifDers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiniflarId",
                table: "SinifDers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
