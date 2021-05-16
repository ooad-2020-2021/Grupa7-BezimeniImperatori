using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Pacijent : Korisnik
    {
        #region Properties
        [Required]
        [DataType(DataType.Date)]
        public DateTime datumRodjenja { get; set; }
        [Required]
        public string brojTelefona { get; set; }

        [Required]
        public char spol { get; set; }

        [Required]
        public string prebivaliste { get; set; }
        [Required]
        public string jedinstveniMatičniBroj { get; set; }

        public string zdravstveneNapomene { get; set; }

        public LoyalKartica? loyalKartica  { get; set; }

        #endregion
        #region Konstruktor i destruktor
        public Pacijent(int iD, string imePrezime, string email, string sifra, DateTime datumRodjenja, string brojTelefona, char spol, string prebivaliste, string jedinstveniMatičniBroj, string zdravstveneNapomene, LoyalKartica loyalKartica) : base(iD, imePrezime, email, sifra)
        {
            this.datumRodjenja = datumRodjenja;
            this.brojTelefona = brojTelefona;
            this.spol = spol;
            this.prebivaliste = prebivaliste;
            this.jedinstveniMatičniBroj = jedinstveniMatičniBroj;
            this.zdravstveneNapomene = zdravstveneNapomene;
            this.loyalKartica = loyalKartica;
        }
        ~Pacijent()
        {
           loyalKartica = null; //mozda ne treba uopce
        }
        #endregion
        #region Metode

        void Pregledaj(interface Pregledanje)
        {
         Pregledanje();
        }
        #endregion
    }
}
