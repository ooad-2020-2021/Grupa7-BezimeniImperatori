using System;
using System.ComponentModel.DataAnnotations;

namespace JAWS.Models
{
    public class LoyalKartica
    {
        #region Properties
        [Key]
        [Required]
        public int id { get; set; }
        public static int trajanjeKarticeUMjesecima { get; set; } = 6;
        [Required]
        [DataType(DataType.Date)]
        public DateTime datumKreiranja { get; set; }
        public static double iznosFiksnogPopusta { get; set; } = 0.05;
        public static double iznosPopustaNaBrojUsluga { get; set; } = 0.20;
        /*public bool aktivna;
        [DataType(DataType.Date)]
        public DateTime datumIsteka;*/

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