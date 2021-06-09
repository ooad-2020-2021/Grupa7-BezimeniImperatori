using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public enum Spol
    {
        [Display(Name = "Muško")]
        M,
        [Display(Name = "Žensko")]
        Z,
    }
    [NotMapped]
    public class Pacijent : Korisnik
    {
        #region Properties
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum rođenja: ")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime DatumRodjenja { get; set; }

        [Required]
        [DisplayName("Broj telefona: ")]
        public string BrojTelefona { get; set; }

        [Required]
        [EnumDataType(typeof(Spol))]
        [DisplayName("Spol: ")]
        public char Spol { get; set; }

        [Required]
        [DisplayName("Prebivalište: ")]
        public string Prebivaliste { get; set; }

        [Required]
        [DisplayName("Jedinstveni matični broj: ")]
        public string JedinstveniMatičniBroj { get; set; }

        [DisplayName("Zdravstvene napomene: ")]
        public string ZdravstveneNapomene { get; set; }
        //ima loyal karticu da/ne
        [ForeignKey("LoyalKartica")]
        public int LoyalKarticaId { get; set; }

        #endregion
        #region Konstruktor i destruktor
        public Pacijent()
        {

        }
        public Pacijent(int Id, string imePrezime, string email, string sifra, DateTime datumRodjenja, string brojTelefona, char spol, string prebivaliste, string jedinstveniMatičniBroj, string zdravstveneNapomene) : base(Id, imePrezime, email, sifra)
        {
            this.DatumRodjenja = datumRodjenja;
            this.BrojTelefona = brojTelefona;
            this.Spol = spol;
            this.Prebivaliste = prebivaliste;
            this.JedinstveniMatičniBroj = jedinstveniMatičniBroj;
            this.ZdravstveneNapomene = zdravstveneNapomene;
        }
        ~Pacijent()
        {

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
