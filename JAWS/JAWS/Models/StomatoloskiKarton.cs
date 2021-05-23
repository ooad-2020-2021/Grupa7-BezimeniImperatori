using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class StomatoloskiKarton
    {
        
        #region Properties

        [Key]
        [Required]
        [DisplayName("Broj kartona: ")]
        public int Id { get; set; }

        [Required]
        //[DisplayName("Pacijent: ")]
        public Pacijent pacijent { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum otvaranja kartona: ")]
        public DateTime datumOtvaranjaKartona { get; set; }


        [NotMapped]
        public List<string> medicinskiPodaci { get; set; }

        [NotMapped]
        public List<StomatoloskaUsluga> kolekcijaUsluga { get; set; }

        [DisplayName("Posjeduje loyal karticu")]
        public bool posjedovanjeLoyalKartice { get; set; } = false;

        #endregion

        #region Konstruktori

    public StomatoloskiKarton(int Id, DateTime datumOtvaranjaKartona, Pacijent pacijent, List<string> medicinksiPodaci)
        {
            this.Id = Id;
            this.datumOtvaranjaKartona = datumOtvaranjaKartona;
            this.pacijent = pacijent;
            this.medicinskiPodaci = medicinksiPodaci;
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
