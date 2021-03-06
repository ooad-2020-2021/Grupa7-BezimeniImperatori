// <auto-generated />
using System;
using JAWS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JAWS.Migrations
{
    [DbContext(typeof(JAWSContext))]
    partial class JAWSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JAWS.Models.Cjenovnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Cjenovnik");
                });

            modelBuilder.Entity("JAWS.Models.CjenovnikItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<int>("CjenovnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CjenovnikItem");
                });

            modelBuilder.Entity("JAWS.Models.KnjigaProtokola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NapomeneZaDoktora")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KnjigaProtokola");
                });

            modelBuilder.Entity("JAWS.Models.Kontakt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazivFirme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.HasKey("Id");

                    b.ToTable("Kontakt");
                });

            modelBuilder.Entity("JAWS.Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImePrezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnikTip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.HasKey("Id");

                    b.ToTable("Korisnik");

                    b.HasDiscriminator<string>("KorisnikTip").HasValue("Korisnik");
                });

            modelBuilder.Entity("JAWS.Models.LoyalKartica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LoyalKartica");
                });

            modelBuilder.Entity("JAWS.Models.StomatoloskaUsluga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPruzanjaUsluga")
                        .HasColumnType("datetime2");

                    b.Property<string>("IzvjestajTerapije")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.Property<int>("KartonId")
                        .HasColumnType("int");

                    b.Property<int>("KnjigaProtokolaId")
                        .HasColumnType("int");

                    b.Property<string>("Napomene")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oboljenje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpisUsluge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RtgSnimak")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StomatoloskaUsluga");
                });

            modelBuilder.Entity("JAWS.Models.StomatoloskiKarton", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumOtvaranjaKartona")
                        .HasColumnType("datetime2");

                    b.Property<int>("PacijentId")
                        .HasColumnType("int");

                    b.Property<bool>("PosjedovanjeLoyalKartice")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("StomatoloskiKarton");
                });

            modelBuilder.Entity("JAWS.Models.Termin", b =>
                {
                    b.Property<int>("TerminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ObrazlozenjeTermina")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.Property<int>("PacijentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VrijemeTermina")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ZauzetostTermina")
                        .HasColumnType("bit");

                    b.HasKey("TerminId");

                    b.ToTable("Termin");
                });

            modelBuilder.Entity("JAWS.Models.Doktor", b =>
                {
                    b.HasBaseType("JAWS.Models.Korisnik");

                    b.HasDiscriminator().HasValue("Doktor");
                });

            modelBuilder.Entity("JAWS.Models.Pacijent", b =>
                {
                    b.HasBaseType("JAWS.Models.Korisnik");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("JedinstveniMatičniBroj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoyalKarticaId")
                        .HasColumnType("int");

                    b.Property<string>("Prebivaliste")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Spol")
                        .HasColumnType("int");

                    b.Property<string>("ZdravstveneNapomene")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Pacijent");
                });
#pragma warning restore 612, 618
        }
    }
}
