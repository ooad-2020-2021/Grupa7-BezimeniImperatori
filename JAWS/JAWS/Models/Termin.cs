using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Termin
    {
       
        #region Properties

        //[Required]
        public Pacijent? pacijent { get; set; }

        //[Required]
        public DateTime vrijemeTermina { get; set; }

        [Required]
        public bool zauzetostTermina { get; set; } = false;

        [Required]
        public string obrazlozenjeTermina { get; set; } = "";


        #endregion
        
        public Termin(Pacijent pacijent, DateTime vrijemeTermina, string obrazlozenjeTermina)
        {
            this.pacijent = pacijent;
            this.vrijemeTermina = vrijemeTermina;
            this.zauzetostTermina = true;
            this.obrazlozenjeTermina = obrazlozenjeTermina;
        }
    }
}
