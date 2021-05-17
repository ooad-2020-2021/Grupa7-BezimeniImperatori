using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Doktor : Korisnik
    {
        #region Properties

        #endregion

        #region Konstruktor i destruktor
        public Doktor(int iD, string imePrezime, string email, string sifra) : base(iD, imePrezime, email, sifra) { }
        #endregion

        #region Metode
       /* void Pregledaj(interface Pregledanje)
        {
        Pregledanje();
        }*/
        #endregion

    }
}
