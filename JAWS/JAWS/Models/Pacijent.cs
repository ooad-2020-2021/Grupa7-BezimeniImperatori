using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Datum rođenja: ")]
        public DateTime datumRodjenja { get; set; }
        [Required]
        [DisplayName("Broj telefona: ")]
        public string brojTelefona { get; set; }

        [Required]
        [DisplayName("Spol: ")] //enum?
        public char spol { get; set; }

        [Required]
        [DisplayName("Prebivalište: ")]
        public string prebivaliste { get; set; }
        [Required]
        [DisplayName("Prebivalište: ")]
        public string jedinstveniMatičniBroj { get; set; }
        [DisplayName("Zdravstvene napomene: ")]
        public string zdravstveneNapomene { get; set; }
        //ima loyal karticu da/ne
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

        /*void Pregledaj(interface Pregledanje)
        {
         Pregledanje();
        }*/
        #endregion
    }
}
