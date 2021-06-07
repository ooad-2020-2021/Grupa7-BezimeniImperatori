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
        [ForeignKey("Pacijent: ")]
        public int PacijentId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum otvaranja kartona: ")]
        public DateTime DatumOtvaranjaKartona { get; set; }


        [NotMapped]
        public List<string> MedicinskiPodaci { get; set; }

        //izbrisana kolekcija usluga
        [DisplayName("Posjeduje loyal karticu")]
        public bool PosjedovanjeLoyalKartice { get; set; } = false;

        #endregion

        #region Konstruktori

        public StomatoloskiKarton() { }

    public StomatoloskiKarton(int Id, DateTime datumOtvaranjaKartona, int PacijentId, List<string> medicinksiPodaci)
        {
            this.Id = Id;
            this.DatumOtvaranjaKartona = datumOtvaranjaKartona;
            this.PacijentId = PacijentId; //preko baze
            this.MedicinskiPodaci = medicinksiPodaci;
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
            return PosjedovanjeLoyalKartice;
        }

        #endregion

    }
}
