using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JAWS.Models
{
    public class CjenovnikItem
    {
        #region Properties
        [Key]
        [Required]
        [DisplayName("Id Stavke: ")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Naziv: ")]
        public string Naziv { get; set; }

        [Required]
        [DisplayName("Cijena: ")]
        public double Cijena { get; set; }

        [ForeignKey("Cjenovnik")]
        public int CjenovnikId { get; set; }
        #endregion

        #region Konstruktor
        public CjenovnikItem(int id, string naziv, double cijena)
        {
            Id = id;
            Naziv = naziv;
            Cijena = cijena;
        }
        public CjenovnikItem()
        {
        }
        #endregion
    }
}
