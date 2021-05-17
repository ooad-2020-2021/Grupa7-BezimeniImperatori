using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Cjenovnik
    {

        #region Properties

        [NotMapped]
        public List<Tuple<string, double>> uslugeICijene { get; set; } = new List<Tuple<string, double>>();

        #endregion

        #region Konstruktori

        public Cjenovnik()
        {
        }

        #endregion

        #region Metode 
        //treba napisati metodu promjeni cijene

        public void dodajUslugu(string nazivUsluge, double cijenaUsluge)
        {
            uslugeICijene.Add(new Tuple<string, double>(nazivUsluge, cijenaUsluge));
        }

        public void promijeniCijenu(string nazivUsluge, double novaCijenaUsluge)
        {
            //uslugeICijene[nazivUsluge].Item2 = novaCijenaUsluge;
            /*       foreach(var first in uslugeICijene)
               {
                   if(first.Item1 == nazivUsluge)
                   {
                       //first.Item2 = novaCijenaUsluge;
                   }
                   //treba uraditi ovu metodu
               }
               //uslugeICijene = new Tuple<string, double>(nazivUsluge, cijenaUsluge);
           */
        }

        public void promijeniNazivUsluge(string nazivUsluge, string noviNazivUsluge)
        {
            
        }

        #endregion
    }
}
