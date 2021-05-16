using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class StomatoloskiKarton
    {
        
        #region Properties

        [Key]
        [Required]
        public int brojKartona { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime datumOtvaranjaKartona { get; set; }

        [Required]
        public Pacijent pacijent { get; set; }

        public List<string> medicinksiPodaci { get; set; }

        public List<StomatoloskaUsluga> kolekcijaUsluga { get; set; }

        public bool posjedovanjeLoyalKartice { get; set; } = false;

        #endregion

        #region Konstruktori

    public StomatoloskiKarton(int brojKartona, DateTime datumOtvaranjaKartona, Pacijent pacijent, List<string> medicinksiPodaci)
        {
            this.brojKartona = brojKartona;
            this.datumOtvaranjaKartona = datumOtvaranjaKartona;
            this.pacijent = pacijent;
            this.medicinksiPodaci = medicinksiPodaci;
        }

        #endregion

        #region Metode

        /*public List<StomatoloskaUsluga> dajUslugeObavljeneNaTerminu(DateTime datumTermina)
        {
            foreach(var dat in kolekcijaUsluga)
            {
                if(dat.datumPruzanjaUsluga)
            }
        }
        */

        public Boolean DaLiPosjedujeKarticu()
        {
            return posjedovanjeLoyalKartice;
        }

        #endregion

    }
}
