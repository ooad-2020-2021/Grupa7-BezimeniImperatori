using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JAWS.Models;

namespace JAWS.Data
{
    public class JAWSContext : DbContext
    {
        public JAWSContext (DbContextOptions<JAWSContext> options)
            : base(options)
        {
        }
        public DbSet<JAWS.Models.CjenovnikItem> CjenovnikItem { get; set; }

        public DbSet<JAWS.Models.LoyalKartica> LoyalKartica { get; set; }

        public DbSet<JAWS.Models.Kontakt> Kontakt { get; set; }
        public DbSet<JAWS.Models.Pacijent> Pacijent { get; set; }

        public DbSet<JAWS.Models.Doktor> Doktor { get; set; }

        public DbSet<JAWS.Models.Termin> Termin { get; set; }

        public DbSet<JAWS.Models.KnjigaProtokola> KnjigaProtokola { get; set; }

        public DbSet<JAWS.Models.StomatoloskaUsluga> StomatoloskaUsluga { get; set; }

        public DbSet<JAWS.Models.StomatoloskiKarton> StomatoloskiKarton { get; set; }

        public DbSet<JAWS.Models.Korisnik> Korisnik { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Korisnik>()
                .ToTable("Korisnik")
                .HasDiscriminator<string>("KorisnikTip")
                .HasValue<Pacijent>("Pacijent")
                .HasValue<Doktor>("Doktor");
            modelBuilder.Entity<LoyalKartica>().ToTable("LoyalKartica");
            modelBuilder.Entity<Kontakt>().ToTable("Kontakt");
            modelBuilder.Entity<Termin>().ToTable("Termin");
            modelBuilder.Entity<KnjigaProtokola>().ToTable("KnjigaProtokola");
            modelBuilder.Entity<StomatoloskaUsluga>().ToTable("StomatoloskaUsluga");
            modelBuilder.Entity<StomatoloskiKarton>().ToTable("StomatoloskiKarton");
            modelBuilder.Entity<CjenovnikItem>().ToTable("CjenovnikItem");
        }

        public DbSet<JAWS.Models.Cjenovnik> Cjenovnik { get; set; }
    }
}
