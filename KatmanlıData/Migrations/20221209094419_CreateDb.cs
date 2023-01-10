using Microsoft.EntityFrameworkCore.Migrations;

namespace KatmanlıData.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminAdı = table.Column<string>(nullable: true),
                    AdminSifre = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Diziler",
                columns: table => new
                {
                    DiziId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiziAdı = table.Column<string>(nullable: true),
                    DiziAcıklama = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    DiziYönetmen = table.Column<string>(nullable: true),
                    DiziYıl = table.Column<int>(nullable: false),
                    DiziTür = table.Column<string>(nullable: true),
                    DiziPuan = table.Column<int>(nullable: false),
                    DiziYayıncı = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diziler", x => x.DiziId);
                });

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAdı = table.Column<string>(nullable: true),
                    FilmAcıklma = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    FilmYönetmen = table.Column<string>(nullable: true),
                    FilmYıl = table.Column<int>(nullable: false),
                    FilmTür = table.Column<string>(nullable: true),
                    FilmPuan = table.Column<int>(nullable: false),
                    Yayıncı = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.FilmId);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcı",
                columns: table => new
                {
                    KullanıcıId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullanıcıAdı = table.Column<string>(nullable: false),
                    KullanıcıSifre = table.Column<string>(nullable: false),
                    Yas = table.Column<int>(nullable: false),
                    KullanıcıUlke = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcı", x => x.KullanıcıId);
                });

            migrationBuilder.CreateTable(
                name: "DiziIzlemeListesi",
                columns: table => new
                {
                    ListeNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiziId = table.Column<int>(nullable: false),
                    DiziAdı = table.Column<int>(nullable: false),
                    DizilerDiziId = table.Column<int>(nullable: true),
                    KullanıcıId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiziIzlemeListesi", x => x.ListeNo);
                    table.ForeignKey(
                        name: "FK_DiziIzlemeListesi_Diziler_DizilerDiziId",
                        column: x => x.DizilerDiziId,
                        principalTable: "Diziler",
                        principalColumn: "DiziId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiziIzlemeListesi_Kullanıcı_KullanıcıId",
                        column: x => x.KullanıcıId,
                        principalTable: "Kullanıcı",
                        principalColumn: "KullanıcıId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiziYorumlar",
                columns: table => new
                {
                    ListeNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yorumlar = table.Column<string>(nullable: true),
                    DiziPuan = table.Column<int>(nullable: false),
                    DiziId = table.Column<int>(nullable: false),
                    DizilerDiziId = table.Column<int>(nullable: true),
                    KullanıcıId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiziYorumlar", x => x.ListeNo);
                    table.ForeignKey(
                        name: "FK_DiziYorumlar_Diziler_DizilerDiziId",
                        column: x => x.DizilerDiziId,
                        principalTable: "Diziler",
                        principalColumn: "DiziId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiziYorumlar_Kullanıcı_KullanıcıId",
                        column: x => x.KullanıcıId,
                        principalTable: "Kullanıcı",
                        principalColumn: "KullanıcıId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmIzlemeListesi",
                columns: table => new
                {
                    ListeNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(nullable: false),
                    FilmAdı = table.Column<string>(nullable: true),
                    FilmlerFilmId = table.Column<int>(nullable: true),
                    KullanıcıId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmIzlemeListesi", x => x.ListeNo);
                    table.ForeignKey(
                        name: "FK_FilmIzlemeListesi_Filmler_FilmlerFilmId",
                        column: x => x.FilmlerFilmId,
                        principalTable: "Filmler",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmIzlemeListesi_Kullanıcı_KullanıcıId",
                        column: x => x.KullanıcıId,
                        principalTable: "Kullanıcı",
                        principalColumn: "KullanıcıId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmYorumlar",
                columns: table => new
                {
                    ListeNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yorumlar = table.Column<string>(nullable: true),
                    FilmPuan = table.Column<int>(nullable: false),
                    FilmId = table.Column<int>(nullable: false),
                    FilmlerFilmId = table.Column<int>(nullable: true),
                    KullanıcıId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmYorumlar", x => x.ListeNo);
                    table.ForeignKey(
                        name: "FK_FilmYorumlar_Filmler_FilmlerFilmId",
                        column: x => x.FilmlerFilmId,
                        principalTable: "Filmler",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmYorumlar_Kullanıcı_KullanıcıId",
                        column: x => x.KullanıcıId,
                        principalTable: "Kullanıcı",
                        principalColumn: "KullanıcıId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiziIzlemeListesi_DizilerDiziId",
                table: "DiziIzlemeListesi",
                column: "DizilerDiziId");

            migrationBuilder.CreateIndex(
                name: "IX_DiziIzlemeListesi_KullanıcıId",
                table: "DiziIzlemeListesi",
                column: "KullanıcıId");

            migrationBuilder.CreateIndex(
                name: "IX_DiziYorumlar_DizilerDiziId",
                table: "DiziYorumlar",
                column: "DizilerDiziId");

            migrationBuilder.CreateIndex(
                name: "IX_DiziYorumlar_KullanıcıId",
                table: "DiziYorumlar",
                column: "KullanıcıId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmIzlemeListesi_FilmlerFilmId",
                table: "FilmIzlemeListesi",
                column: "FilmlerFilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmIzlemeListesi_KullanıcıId",
                table: "FilmIzlemeListesi",
                column: "KullanıcıId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmYorumlar_FilmlerFilmId",
                table: "FilmYorumlar",
                column: "FilmlerFilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmYorumlar_KullanıcıId",
                table: "FilmYorumlar",
                column: "KullanıcıId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "DiziIzlemeListesi");

            migrationBuilder.DropTable(
                name: "DiziYorumlar");

            migrationBuilder.DropTable(
                name: "FilmIzlemeListesi");

            migrationBuilder.DropTable(
                name: "FilmYorumlar");

            migrationBuilder.DropTable(
                name: "Diziler");

            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "Kullanıcı");
        }
    }
}
