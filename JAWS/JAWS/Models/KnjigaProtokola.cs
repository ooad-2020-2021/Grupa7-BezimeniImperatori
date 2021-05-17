using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class KnjigaProtokola
    {
        #region Properties
        [NotMapped]
        public List<StomatoloskaUsluga> stomatoloskeUsluge { get; set; } = new List<StomatoloskaUsluga>();

        #endregion

        #region Konstruktori

        public KnjigaProtokola()
        {
        }

        #endregion

        #region Metode


        #endregion
    }
}
