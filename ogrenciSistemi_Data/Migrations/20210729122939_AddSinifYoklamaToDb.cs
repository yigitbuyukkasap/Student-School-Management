using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ogrenciSistemi_Data.Migrations
{
    public partial class AddSinifYoklamaToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SinifYoklama",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    OgretmenId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    YoklamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinifYoklama", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinifYoklama_AspNetUsers_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinifYoklama_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinifYoklama_Siniflar_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Siniflar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinifYoklama_DersId",
                table: "SinifYoklama",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_SinifYoklama_OgretmenId",
                table: "SinifYoklama",
                column: "OgretmenId");

            migrationBuilder.CreateIndex(
                name: "IX_SinifYoklama_SinifId",
                table: "SinifYoklama",
                column: "SinifId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinifYoklama");
        }
    }
}
