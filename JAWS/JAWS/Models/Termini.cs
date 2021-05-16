using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Termini
    {
        #region Properties

        [Key]
        [Required]
        public List<Termin> termini { get; set; }

        #endregion
    }
}
