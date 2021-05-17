using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Adresar
    {

        #region Properties

        [NotMapped]
        public List<Kontakt> kontakti { get; set; } = new List<Kontakt> ();

        #endregion

        #region Konstruktori

        public Adresar()
        {
        }
        #endregion

        #region Metode

        public void dodajKontakt(Kontakt kontakt)
        {
            kontakti.Add(kontakt);
        }

        public void izbrisiKontakt(int id)
        {
            kontakti.Remove(kontakti[id]);
        }

        public string dajPodatkeOKontaktu(Kontakt kontakt)
        {
            return ("Naziv firme: " + kontakt.nazivFirme + "\nBroj telefona: " + kontakt.brojTelefona + "\nAdresa: " + kontakt.adresa);
        }

        #endregion

    }
}
