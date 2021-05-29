using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    public class AdresarAdapter : ITarget
    {
        #region Properties
        public Adresar adresar;
        #endregion

        #region Metode
        public void SortirajAdresar()
        {
            //implementirati nakon baze
        }
       

        public Kontakt PretraziAdresar(string nazivFirme)
        {
            throw new NotImplementedException(); //implementirati nakon baze
        }
        #endregion
    }
}
