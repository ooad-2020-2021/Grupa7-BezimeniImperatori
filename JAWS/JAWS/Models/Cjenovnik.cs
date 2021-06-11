using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Key]
        [Required]
        [DisplayName("Id Cjenovnika: ")] //probali smo pronaći anotaciju za klas bez PK, nismo uspjeli
        public int Id { get; set; }

        [NotMapped]
        public static List<CjenovnikItem> CjenovnikLista { get; set; } = new List<CjenovnikItem>();

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

        public void DodajUslugu(CjenovnikItem Stavka)
        {
            CjenovnikLista.Add(Stavka);
        }

        public void PromijeniCijenu(CjenovnikItem Stavka, double Cijena)
        {
            CjenovnikLista.Find(x => x.Id == Stavka.Id).Cijena = Cijena;
        }
        public void PromijeniNazivUsluge(CjenovnikItem Stavka, string NoviNazivUsluge)
        {
            CjenovnikLista.Find(x => x.Id == Stavka.Id).Naziv = NoviNazivUsluge;
        }
        #endregion
    }
}