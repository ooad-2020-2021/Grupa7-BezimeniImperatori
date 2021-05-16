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
        public List<Kontakt> kontakti { get; set; }

        #endregion
        
        public Adresar()
        {
        }

        #region Metode

        public void dodajKontakt(Kontakt kontakt)
        {
            kontakti.Add(kontakt);
        }

        public void izbrisiKontakt(Kontakt kontakt)
        {
            kontakti.Remove(kontakt);
        }

        public string dajPodatkeOKontaktu(Kontakt kontakt)
        {
            return ("Naziv firme: " + kontakt.nazivFirme + "\nBroj telefona: " + kontakt.brojTelefona + "\nAdresa: " + kontakt.adresa);
        }

        #endregion

    }
}
