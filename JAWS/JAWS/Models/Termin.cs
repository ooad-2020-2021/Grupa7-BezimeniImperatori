using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class DatumIzProšlosti : RangeAttribute //dodati klasu
    {
        public DatumIzProšlosti() : base(typeof(DateTime), DateTime.MinValue.ToString(), DateTime.Now.ToString())
        {

        }
    }
    public class Termin
    {

        #region Properties
        [Required]
        [ForeignKey("Pacijent: ")] //Referenca na pacijenta koji je zauzeo Termin
        public int PacijentId { get; set; }

        [Required]
        [DisplayName("Vrijeme željenog termina: ")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy HH:mm}")]
        public DateTime VrijemeTermina { get; set; }
        
        [Required]
        [DisplayName("Zauzetost: ")]
        public bool ZauzetostTermina { get; set; } = false;

        [DisplayName("Obrazloženje za zakazivanje termina: ")]
        [StringLength(int.MaxValue, MinimumLength = 10, ErrorMessage = "Obrazloženje zakazivanja termina mora imati barem 10 karaktera!")]
        public string ObrazlozenjeTermina { get; set; } = "";

        public int TerminId { get; set; }

        #endregion

        #region Konstruktor
        public Termin()
        {

        }
        public Termin(int pacijentId, DateTime vrijemeTermina, string obrazlozenjeTermina)
        {
            this.PacijentId = pacijentId;
            this.VrijemeTermina = vrijemeTermina;
            this.ZauzetostTermina = true;
            this.ObrazlozenjeTermina = obrazlozenjeTermina;
        }
        #endregion
    }
}
