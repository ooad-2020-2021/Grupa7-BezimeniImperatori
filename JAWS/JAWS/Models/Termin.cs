using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        //[DisplayName("")]
        public Pacijent? Pacijent { get; set; }

        [Required]
        [DisplayName("Vrijeme željenog termina: ")]
<<<<<<< HEAD
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy HH:mm}")]
        public DateTime vrijemeTermina { get; set; }
=======
        [DatumIzProšlosti(ErrorMessage = "Neispravan datum!")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy HH:mm}")]
        public DateTime VrijemeTermina { get; set; }
>>>>>>> c207b7e8eedb2d7dc16e68601d53b26cf7ae54f1

        [Required]
        public bool ZauzetostTermina { get; set; } = false;

        [DisplayName("Obrazloženje za zakazivanje termina: ")]
        [StringLength(int.MaxValue, MinimumLength = 10, ErrorMessage = "Obrazloženje zakazivanja termina mora imati barem 10 karaktera!")]
        public string ObrazlozenjeTermina { get; set; } = "";


        #endregion

        #region Konstruktor

        public Termin(Pacijent pacijent, DateTime vrijemeTermina, string obrazlozenjeTermina)
        {
            this.Pacijent = pacijent;
            this.VrijemeTermina = vrijemeTermina;
            this.ZauzetostTermina = true;
            this.ObrazlozenjeTermina = obrazlozenjeTermina;
        }
        #endregion
    }
}
