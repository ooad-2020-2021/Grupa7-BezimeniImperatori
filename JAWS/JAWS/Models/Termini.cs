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
        private static Termini instance { get; set; }

        #endregion

        #region Konstruktor

        private Termini()
        {
        }

        #endregion

        #region Metode

        public static Termini GetInstance()
        {
            if (instance == null)
            {
                instance= new Termini();
                instance = new List<Termin>();
            }
            return instance;
        }

        public void dodajTermin(Termin termin)
        {
            termini.Add(termin);
        }

        public void izbaciTermin(Termin termin)
        {
            termini.Remove(termin);
        }

        public Termin vratiTermin(DateTime datumVrijeme)
        {
           var t = termini.Find()
        }

        #endregion
    }
}
