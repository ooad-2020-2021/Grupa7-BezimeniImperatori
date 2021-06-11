using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class KnjigaProtokola : ISortiranje //Lista svih usluga
    {
        #region Instance

        [NotMapped]
        private static KnjigaProtokola Instance;

        #endregion

        #region Properties

        /* [NotMapped]
         public static List<StomatoloskaUsluga> KnjigaProtokolaList { get; set; } = new List<StomatoloskaUsluga>(); */

        [Key]
        [Required]
        [DisplayName("Id knjige protokola: ")]
        public int Id { get; set; }
        public string NapomeneZaDoktora { get; set; }

        #endregion

        #region Konstruktori

        private KnjigaProtokola()
        {
        }

        #endregion


        #region Metode

        public static KnjigaProtokola DajKnjiguProtokola()
        {
            if (Instance == null)
            {
                Instance = new KnjigaProtokola();
            }
            return Instance;
        }


        public void SortirajUsluge(List<StomatoloskaUsluga> Usluge)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
