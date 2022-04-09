using Microsoft.EntityFrameworkCore.Migrations;

namespace ogrenciSistemi_Data.Migrations
{
    public partial class AddSinifYoklamaListesiToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SinifYoklamaListesi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifYoklamaId = table.Column<int>(type: "int", nullable: false),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinifYoklamaListesi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinifYoklamaListesi_Ogrenci_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinifYoklamaListesi_SinifYoklama_SinifYoklamaId",
                        column: x => x.SinifYoklamaId,
                        principalTable: "SinifYoklama",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinifYoklamaListesi_OgrenciId",
                table: "SinifYoklamaListesi",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_SinifYoklamaListesi_SinifYoklamaId",
                table: "SinifYoklamaListesi",
                column: "SinifYoklamaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinifYoklamaListesi");
        }
    }
}
