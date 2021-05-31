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
        public int Id { get; set; }

        [Required]
        [DisplayName("Ime i Prezime: ")]
        public string ImePrezime { get; set; }

        [Required]
        [DisplayName("E-mail: ")]
        public string Email { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 6, ErrorMessage = "Nedovoljan broj karaktera!")]
        [DisplayName("Šifra (minimum 6 karaktera): ")]
        public string Sifra { get; set; }
        #endregion
        #region Konstruktor
        public Korisnik() { }
        public Korisnik(int Id, string imePrezime, string email, string sifra)
        {
            this.Id = Id;
            this.ImePrezime = imePrezime;
            this.Email = email;
            this.Sifra = sifra;
        }

        #endregion
        #region Metode

        public void PromijeniSifru(string novaSifra)
        {
            Sifra = novaSifra;
        }

        #endregion
    }
}
