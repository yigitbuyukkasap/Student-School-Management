using Microsoft.EntityFrameworkCore.Migrations;

namespace ogrenciSistemi_Data.Migrations
{
    public partial class AddOgretmenDersToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OgretmenDers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgretmenId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SinifIarId = table.Column<int>(type: "int", nullable: true),
                    DersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretmenDers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgretmenDers_AspNetUsers_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgretmenDers_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgretmenDers_Siniflar_SinifIarId",
                        column: x => x.SinifIarId,
                        principalTable: "Siniflar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenDers_DersId",
                table: "OgretmenDers",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenDers_OgretmenId",
                table: "OgretmenDers",
                column: "OgretmenId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenDers_SinifIarId",
                table: "OgretmenDers",
                column: "SinifIarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgretmenDers");
        }
    }
}
