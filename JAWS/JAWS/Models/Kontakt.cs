using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Kontakt
    {        
        #region Properties

        [Key]
        [Required]
        [DisplayName("ID: ")]
        public int id { get; set; }

        [Required]
        [DisplayName("Naziv firme: ")]
        [StringLength(int.MaxValue, MinimumLength = 3, ErrorMessage = "Naziv firme mora imati barem 3 karaktera!")]
        public string nazivFirme { get; set; }

        [Required]
        [DisplayName("Broj telefona: ")]
        [DisplayFormat(DataFormatString = "{DDD/DDD-DDD}")]
        public string brojTelefona { get; set; }

        [Required]
        [DisplayName("Adresa: ")]
        public string adresa { get; set; }

        #endregion

        #region Konstruktori
        public Kontakt(string nazivFirme, string brojTelefona, string adresa)
        {
            this.nazivFirme = nazivFirme;
            this.brojTelefona = brojTelefona;
            this.adresa = adresa;
        }

        #endregion


    }
}
