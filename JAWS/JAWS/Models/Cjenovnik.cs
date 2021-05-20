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
        #region Instance

        [NotMapped]
        private static Cjenovnik Instance;
        #endregion
        #region Properties

        [NotMapped]
        public static List<Tuple<string, double>> UslugeICijene { get; set; } = new List<Tuple<string, double>>();

        #endregion

        #region Konstruktori

        public Cjenovnik()
        {
        }

        #endregion

        #region Metode 
        //treba napisati metodu promjeni cijene
        public static Cjenovnik DajCjenovnik()
        {
            if (Instance == null)
            {
                Instance = new Cjenovnik();
            }
            return Instance;
        }

        public void DodajUslugu(string nazivUsluge, double cijenaUsluge)
        {
            UslugeICijene.Add(new Tuple<string, double>(nazivUsluge, cijenaUsluge));
        }

        public void PromijeniCijenu(string nazivUsluge, double novaCijenaUsluge)
        {           
                 foreach(var Usluga in UslugeICijene)
               {
                   if(Usluga.Item1.Equals(nazivUsluge))
                   {
                    UslugeICijene.Remove(Usluga);
                    UslugeICijene.Add(new Tuple<string, double>(nazivUsluge, novaCijenaUsluge));
                   }
               }   
        }
        public void PromijeniNazivUsluge(string noviNazivUsluge, double cijenaUsluge)
        {
            foreach (var Usluga in UslugeICijene)
            {
                if (Usluga.Item2==cijenaUsluge)
                {
                    UslugeICijene.Remove(Usluga);
                    UslugeICijene.Add(new Tuple<string, double>(noviNazivUsluge, cijenaUsluge));
                }
            }
        }
        #endregion
    }
}