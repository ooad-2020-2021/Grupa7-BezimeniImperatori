using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class StomatoloskaUsluga
    {

        #region Properties
        [Key]
        [Required]
        [DisplayName("ID Usluge: ")]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum pružanja usluge: ")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime DatumPruzanjaUsluga { get; set; }

        [Required]
        [DisplayName("Oboljenje: ")]
        public string Oboljenje { get; set; }

        [DisplayName("Rtg snimak: ")]
        public string RtgSnimak { get; set; } = ""; 

        [DisplayName("Napomene: ")]
        public string Napomene { get; set; }

        [DisplayName("Opis usluge: ")]
        public string OpisUsluge { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 10, ErrorMessage = "Izvještaj terapije mora imati barem 10 karaktera!")]
        [DisplayName("Izvještaj terapije: ")]
        public string IzvjestajTerapije { get; set; }
        [ForeignKey("StomatoloskiKarton")]
        public int KartonId { get; set; }
    [   ForeignKey("KnjigaProtokola")]
        public int KnjigaProtokolaId { get; set; } //singleton
        #endregion

        #region Konstruktori

        public StomatoloskaUsluga()
        {

        }
        public StomatoloskaUsluga(DateTime datumPruzanjaUsluga, string oboljenje, string izvjestajTerapije)
        {
            this.DatumPruzanjaUsluga = datumPruzanjaUsluga;
            this.Oboljenje = oboljenje;
            this.IzvjestajTerapije = izvjestajTerapije;
        }

        #endregion

        #region Metode

        public string DajOpisUsluge()
        {
            return OpisUsluge;
        }
        
        #endregion

    }
}

