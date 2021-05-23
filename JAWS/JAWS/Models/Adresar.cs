using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class Adresar
    {
        #region Instance

        [NotMapped]
        private static Adresar instance;
        #endregion
        #region Properties

        [NotMapped]
        public static List<Kontakt> Kontakti { get; set; } = new List<Kontakt> ();

        [Required]
        public int Id { get; set; }

        #endregion

        #region Konstruktori

        public Adresar()
        {
        }
        #endregion

        #region Metode
        public static Adresar DajAdresar()
        {
            if (instance == null)
            {
                instance = new Adresar();
            }
            return instance;
        }

        public void DodajKontakt(Kontakt kontakt)
        {
            Kontakti.Add(kontakt);
        }

        public void IzbrisiKontakt(int id)
        {
            Kontakti.Remove(Kontakti[id]);
        }

        public string DajPodatkeOKontaktu(Kontakt kontakt)
        {
            return ("Naziv firme: " + kontakt.nazivFirme + "\nBroj telefona: " + kontakt.brojTelefona + "\nAdresa: " + kontakt.adresa);
        }
/*
        public void specificSortirajAdresar()
        {
            
        }

        public Kontakt scpecificPretraziAdresar(string nazivFirme)
        {

        }
*/
        #endregion

    }
}