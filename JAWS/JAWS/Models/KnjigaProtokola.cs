using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class KnjigaProtokola
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
        [DisplayName("ID knjige protokola: ")]
        public int Id { get; set; }

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

        #endregion
    }
}
