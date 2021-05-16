using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Cjenovnik
    {
        
        #region Properties

        [Required]
        public List<Tuple<string, double>> uslugeICijene { get; set; }

        #endregion
        
        public Cjenovnik()
        {
        }

        #region Metode

        public void dodajUslugu(string nazivUsluge, double cijenaUsluge)
        {
            uslugeICijene.Add(new Tuple<string, double>(nazivUsluge, cijenaUsluge));
        }

        public void promijeniCijenu(string nazivUsluge, double novaCijenaUsluge)
        {
                foreach(var first in uslugeICijene)
            {
                if(first.Item1 == nazivUsluge)
                {
                    //first.Item2 = novaCijenaUsluge;
                }
                //treba uraditi ovu metodu
            }
            //uslugeICijene = new Tuple<string, double>(nazivUsluge, cijenaUsluge);
        }

        #endregion
    }
}
