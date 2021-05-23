using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class StomatoloskaUsluga
    {

        #region Properties
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum pružanja usluge: ")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime datumPruzanjaUsluga { get; set; }

        [Required]
        [DisplayName("Oboljenje: ")]
        public string oboljenje { get; set; }

        [DisplayName("Rtg snimak: ")]
        public string rtgSnimak { get; set; } = ""; //kako realizovati

        [DisplayName("Napomene: ")]
        public string napomene { get; set; }

        [DisplayName("Opis usluge: ")]
        public string opisUsluge { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 10, ErrorMessage = "Izvještaj terapije mora imati barem 10 karaktera!")]
        [DisplayName("Izvještaj terapije: ")]
        public string izvjestajTerapije { get; set; }
        public int kartonId;
        public int knjigaProtokolaId; //singleton
        #endregion

        #region Konstruktori
        
    public StomatoloskaUsluga(DateTime datumPruzanjaUsluga, string oboljenje, string izvjestajTerapije)
        {
            this.datumPruzanjaUsluga = datumPruzanjaUsluga;
            this.oboljenje = oboljenje;
            this.izvjestajTerapije = izvjestajTerapije;
        }

        #endregion

        #region Metode

        public string dajOpisUsluge()
        {
            return opisUsluge;
        }
        
        #endregion

    }
}

