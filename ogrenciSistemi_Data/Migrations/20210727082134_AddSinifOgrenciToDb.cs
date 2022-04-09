using Microsoft.EntityFrameworkCore.Migrations;

namespace ogrenciSistemi_Data.Migrations
{
    public partial class AddSinifOgrenciToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SinifOgrenci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinifOgrenci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinifOgrenci_Ogrenci_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SinifOgrenci_Siniflar_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Siniflar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinifOgrenci_OgrenciId",
                table: "SinifOgrenci",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_SinifOgrenci_SinifId",
                table: "SinifOgrenci",
                column: "SinifId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinifOgrenci");
        }
    }
}
