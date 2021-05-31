using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    //Potrebno implementirati Bridge patern na KorisnikController
    abstract public class Korisnik
    {
        #region Properties
        [Key]
        [Required]
        [DisplayName("ID Korisnika: ")]
        public int ID { get; set; }

        [Required]
        [DisplayName("Ime i Prezime: ")]
        public string imePrezime { get; set; }

        [Required]
        [DisplayName("E-mail: ")]
        public string email { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 6, ErrorMessage = "Nedovoljan broj karaktera!")]
        [DisplayName("Šifra (minimum 6 karaktera): ")]
        public string sifra { get; set; }
        #endregion
        #region Konstruktor
        public Korisnik() { }
        public Korisnik(int iD, string imePrezime, string email, string sifra)
        {
            ID = iD;
            this.imePrezime = imePrezime;
            this.email = email;
            this.sifra = sifra;
        }

        #endregion
        #region Metode

        public void PromijeniSifru(string novaSifra)
        {
            sifra = novaSifra;
        }

        #endregion
    }
}
