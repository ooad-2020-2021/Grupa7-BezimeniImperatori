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
        [DisplayName("Id kartona: ")]
        public int Id { get; set; }

        [Required]
        //[DisplayName("Pacijent: ")]
        public Pacijent Pacijent { get; set; } //da li izbrisati referencu pa staviti FK

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum otvaranja kartona: ")]
        public DateTime datumOtvaranjaKartona { get; set; }


        [NotMapped]
        public List<string> medicinskiPodaci { get; set; }

        //izbrisana kolekcija usluga
        [DisplayName("Posjeduje loyal karticu")]
        public bool posjedovanjeLoyalKartice { get; set; } = false;

        #endregion

        #region Konstruktori

        public StomatoloskiKarton() { }

    public StomatoloskiKarton(int Id, DateTime datumOtvaranjaKartona, Pacijent pacijent, List<string> medicinksiPodaci)
        {
            this.Id = Id;
            this.datumOtvaranjaKartona = datumOtvaranjaKartona;
            this.Pacijent = Pacijent;
            this.medicinskiPodaci = medicinksiPodaci;
        }

        #endregion

        #region Metode

        /*public List<StomatoloskaUsluga> dajUslugeObavljeneNaTerminu(DateTime datumTermina) IMPLEMENTIRATI
        {
            foreach(var dat in kolekcijaUsluga)
            {
                if(dat.datumPruzanjaUsluga) Proci kroz bazu!
            }
        }
        */

        public bool DaLiPosjedujeKarticu()
        {
            return posjedovanjeLoyalKartice;
        }

        #endregion

    }
}
