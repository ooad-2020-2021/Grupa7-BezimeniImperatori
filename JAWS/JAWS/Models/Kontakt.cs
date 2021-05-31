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
        [DisplayName("Id: ")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Naziv firme: ")]
        [StringLength(int.MaxValue, MinimumLength = 3, ErrorMessage = "Naziv firme mora imati barem 3 karaktera!")]
        public string NazivFirme { get; set; }

        [Required]
        [DisplayName("Broj telefona: ")]
        [DisplayFormat(DataFormatString = "{DDD/DDD-DDD}")]
        public string BrojTelefona { get; set; }

        [Required]
        [DisplayName("Adresa: ")]
        public string Adresa { get; set; }

        [ForeignKey("Adresar")]
        public int AdresarId; //Singleton

        #endregion

        #region Konstruktori
        public Kontakt()
        {
        }
        public Kontakt(string nazivFirme, string brojTelefona, string adresa)
        {
            this.NazivFirme = nazivFirme;
            this.BrojTelefona = brojTelefona;
            this.Adresa = adresa;
        }

        #endregion


    }
}
