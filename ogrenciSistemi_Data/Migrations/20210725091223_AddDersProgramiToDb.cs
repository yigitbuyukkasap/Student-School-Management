using Microsoft.EntityFrameworkCore.Migrations;

namespace ogrenciSistemi_Data.Migrations
{
    public partial class AddDersProgramiToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DersProgrami",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    gun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    saat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersProgrami", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DersProgrami_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DersProgrami_Siniflar_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Siniflar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_DersId",
                table: "DersProgrami",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_SinifId",
                table: "DersProgrami",
                column: "SinifId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersProgrami");
        }
    }
}
