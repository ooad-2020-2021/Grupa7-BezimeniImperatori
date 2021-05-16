using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Raspored
    {
        #region Properties

        [NotMapped]
        public Termini termini;
        #endregion

        #region Konstruktor

        public Raspored()
        {
        }

        #endregion

        #region Metode
        //void prikaziSveSlobodneTermine(). VIEW?!?!?!?


        #endregion
    }
}
