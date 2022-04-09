using Microsoft.EntityFrameworkCore.Migrations;

namespace ogrenciSistemi_Data.Migrations
{
    public partial class AddSinifDersToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SinifDers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiniflarId = table.Column<int>(type: "int", nullable: false),
                    SinifIarId = table.Column<int>(type: "int", nullable: true),
                    DersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinifDers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinifDers_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinifDers_Siniflar_SinifIarId",
                        column: x => x.SinifIarId,
                        principalTable: "Siniflar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinifDers_DersId",
                table: "SinifDers",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_SinifDers_SinifIarId",
                table: "SinifDers",
                column: "SinifIarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinifDers");
        }
    }
}
