using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAWS.Migrations
{
    public partial class JAWS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cjenovnik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cjenovnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KnjigaProtokola",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NapomeneZaDoktora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnjigaProtokola", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kontakt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivFirme = table.Column<string>(maxLength: 2147483647, nullable: false),
                    BrojTelefona = table.Column<string>(nullable: false),
                    Adresa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontakt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Sifra = table.Column<string>(maxLength: 2147483647, nullable: false),
                    KorisnikTip = table.Column<string>(nullable: false),
                    DatumRodjenja = table.Column<DateTime>(nullable: true),
                    BrojTelefona = table.Column<string>(nullable: true),
                    Spol = table.Column<string>(nullable: true),
                    Prebivaliste = table.Column<string>(nullable: true),
                    JedinstveniMatičniBroj = table.Column<string>(nullable: true),
                    ZdravstveneNapomene = table.Column<string>(nullable: true),
                    LoyalKarticaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoyalKartica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumKreiranja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoyalKartica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StomatoloskaUsluga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPruzanjaUsluga = table.Column<DateTime>(nullable: false),
                    Oboljenje = table.Column<string>(nullable: false),
                    RtgSnimak = table.Column<string>(nullable: true),
                    Napomene = table.Column<string>(nullable: true),
                    OpisUsluge = table.Column<string>(nullable: true),
                    IzvjestajTerapije = table.Column<string>(maxLength: 2147483647, nullable: false),
                    KartonId = table.Column<int>(nullable: false),
                    KnjigaProtokolaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StomatoloskaUsluga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StomatoloskiKarton",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacijentId = table.Column<int>(nullable: false),
                    DatumOtvaranjaKartona = table.Column<DateTime>(nullable: false),
                    PosjedovanjeLoyalKartice = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StomatoloskiKarton", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Termin",
                columns: table => new
                {
                    TerminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacijentId = table.Column<int>(nullable: false),
                    VrijemeTermina = table.Column<DateTime>(nullable: false),
                    ZauzetostTermina = table.Column<bool>(nullable: false),
                    ObrazlozenjeTermina = table.Column<string>(maxLength: 2147483647, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termin", x => x.TerminId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cjenovnik");

            migrationBuilder.DropTable(
                name: "KnjigaProtokola");

            migrationBuilder.DropTable(
                name: "Kontakt");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "LoyalKartica");

            migrationBuilder.DropTable(
                name: "StomatoloskaUsluga");

            migrationBuilder.DropTable(
                name: "StomatoloskiKarton");

            migrationBuilder.DropTable(
                name: "Termin");
        }
    }
}
