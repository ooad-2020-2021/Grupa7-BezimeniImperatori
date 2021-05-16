using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class StomatoloskaUsluga
    {
<<<<<<< HEAD
       
        #region Properties

        [Required]
        public Pacijent pacijent { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime datumPruzanjaUsluga { get; set; }

        [Required]
        public string oboljenje { get; set; }

        public string rtgSnimak { get; set; } = "";

        public string napomene { get; set; }

        [Required]
        public string izvjestajTerapije { get; set; }

        // public string opisUsluge { get; set; }

        #endregion

        #region Konstruktori
        
    public StomatoloskaUsluga(Pacijent pacijent, DateTime datumPruzanjaUsluga, string oboljenje, string izvjestajTerapije)
        {
            this.pacijent = pacijent;
            this.datumPruzanjaUsluga = datumPruzanjaUsluga;
            this.oboljenje = oboljenje;
            this.izvjestajTerapije = izvjestajTerapije;
        }

        #endregion

        #region Metode

        
        #endregion
=======

>>>>>>> a956c35568d16c241fee7107d246490c1ad67185
    }
}
}
