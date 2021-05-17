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
        public int id { get; set; }

        [DisplayName("Trajanje kartice (mjeseci): ")]
        public static int trajanjeKarticeUMjesecima { get; set; } = 6;
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum kreiranja: ")]
        public DateTime datumKreiranja { get; set; }
        [DisplayName("Iznos fiksnog popusta: ")]
        public static double iznosFiksnogPopusta { get; set; } = 0.05;
        [DisplayName("Iznos popusta na broj usluga: ")]
        public static double iznosPopustaNaBrojUsluga { get; set; } = 0.20;

        #endregion
        #region Konstruktor i destruktor
        public LoyalKartica(int id, DateTime datumKreiranja)
        {
            this.id = id;
            this.datumKreiranja = datumKreiranja;
        }
        #endregion

        #region Metode
        public static void PostaviIznosTrajanja(int mjeseciTrajanjaKartice)
        {
            trajanjeKarticeUMjesecima = mjeseciTrajanjaKartice;
        }
        public static void PostaviIznosFiksnogPopusta(Double iznos)
        {
            iznosFiksnogPopusta = iznos;
        }
        public static void PostaviIznosPopustaNaBrojUsluga(Double iznos)
        {
            iznosPopustaNaBrojUsluga = iznos;
        }
        public DateTime DajDatumIsteka()
        {
            return datumKreiranja.AddMonths(trajanjeKarticeUMjesecima); //get?
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