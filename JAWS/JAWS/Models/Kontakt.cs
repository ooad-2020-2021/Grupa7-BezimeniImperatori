using System;
using System.Collections.Generic;
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
        public int id { get; set; }

        [Required]
        public string nazivFirme { get; set; }

        [Required]
        public string brojTelefona { get; set; }

        [Required]
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
