using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Key]
        [Required]
        [DisplayName("Id adresara: ")]
        public int ID { get; set; }

        public string NazivOrdinacije { get; set; }

        public string BrojTelefonaOrdinacije { get; set; }

        /*[NotMapped]
        public static List<Kontakt> Kontakti { get; set; } = new List<Kontakt> (); */
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
            //pisanje u bazu?
            //Kontakti.Add(kontakt);
        }

        public void IzbrisiKontakt(String nazivFirme) 
        {
            /*foreach (var item in Kontakti)
            {
                if(item.nazivFirme.Equals(nazivFirme))
                    Kontakti.Remove(var);
            }*/
            
        }

        public string DajPodatkeOKontaktu(Kontakt kontakt) 
        {
            // Not developed yet.
            throw new NotImplementedException();
            //return ("Naziv firme: " + kontakt.nazivFirme + "\nBroj telefona: " + kontakt.brojTelefona + "\nAdresa: " + kontakt.adresa);
            //nakon sto se kreira baza implementirati
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