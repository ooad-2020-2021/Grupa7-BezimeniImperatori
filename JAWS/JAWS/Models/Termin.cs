using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Termin
    {
       
        #region Properties

        [Required]
        //[DisplayName("")]
        public Pacijent? pacijent { get; set; }

        [Required]
        [DisplayName("Vrijeme željenog termina: ")]
        public DateTime vrijemeTermina { get; set; }

        [Required]
        public bool zauzetostTermina { get; set; } = false;

        [DisplayName("Obrazloženje za zakazivanje termina: ")]
        public string obrazlozenjeTermina { get; set; } = "";


        #endregion

        #region Konstruktor

        public Termin(Pacijent pacijent, DateTime vrijemeTermina, string obrazlozenjeTermina)
        {
            this.pacijent = pacijent;
            this.vrijemeTermina = vrijemeTermina;
            this.zauzetostTermina = true;
            this.obrazlozenjeTermina = obrazlozenjeTermina;
        }
        #endregion
    }
}
