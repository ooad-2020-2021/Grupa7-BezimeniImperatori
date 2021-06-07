using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JAWS.Models
{

    public class LoyalKartica
    {
        #region Properties
        [Key]
        [Required]
        [DisplayName("ID loyal kartice: ")]
        public int Id { get; set; }

        [DisplayName("Trajanje kartice (mjeseci): ")]
        public static int TrajanjeKarticeUMjesecima { get; set; } = 6;

        [Required]
        [DataType(DataType.Date)]
        [DatumIzProšlosti(ErrorMessage = "Neispravan datum!")]
        [DisplayName("Datum kreiranja: ")]
        public DateTime DatumKreiranja { get; set; }

        [DisplayName("Iznos fiksnog popusta: ")]
        public static double IznosFiksnogPopusta { get; set; } = 0.05;

        [DisplayName("Iznos popusta na broj usluga: ")]
        public static double IznosPopustaNaBrojUsluga { get; set; } = 0.20;

        #endregion
        #region Konstruktor
        public LoyalKartica()
        {
        }
        public LoyalKartica(int id, DateTime datumKreiranja)
        {
            this.Id = id;
            this.DatumKreiranja = datumKreiranja;
        }
        #endregion

        #region Metode
        public static void PostaviIznosTrajanja(int mjeseciTrajanjaKartice)
        {
            TrajanjeKarticeUMjesecima = mjeseciTrajanjaKartice;
        }
        public static void PostaviIznosFiksnogPopusta(Double iznos)
        {
            IznosFiksnogPopusta = iznos;
        }
        public static void PostaviIznosPopustaNaBrojUsluga(Double iznos)
        {
            IznosPopustaNaBrojUsluga = iznos;
        }
        public DateTime DajDatumIsteka()
        {
            return DatumKreiranja.AddMonths(TrajanjeKarticeUMjesecima); //get?
        }
        public bool DajStanjeKartice() //ako je true, aktivna je 
        {
            DateTime Istek = DajDatumIsteka();
            DateTime Trenutno = DateTime.Now;
            if(DateTime.Compare(Istek, Trenutno)<0) return true;
            else return false;
        }
        #endregion
    }
}