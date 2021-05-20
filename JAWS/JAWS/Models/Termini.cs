using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Termini
    {

        #region Instance

        [NotMapped]
        private static Termini Instance;
        #endregion

        #region Konstruktor

        private Termini()
        {
        }

        #endregion
        #region Properties

        [NotMapped]
        public static List<Termin> TerminiList { get; set; } = new List<Termin>();
    #endregion

    #region Metode

        public static Termini DajTermine()
        {
            if (Instance == null)
            {
                Instance = new Termini();
            }
            return Instance;
        }

        public void dodajTermin(Termin termin)
        {
            TerminiList.Add(termin);
        }

        public void izbaciTermin(Termin termin)
        {
            TerminiList.Remove(termin);
        }

        public Termin VratiTermin(DateTime datumVrijeme)
        {
            foreach(var t in TerminiList){ //doraditi
                if (DateTime.Compare(t.VrijemeTermina, datumVrijeme)==0) return t;
            }
            return null;    
        }

        #endregion
    }
}
