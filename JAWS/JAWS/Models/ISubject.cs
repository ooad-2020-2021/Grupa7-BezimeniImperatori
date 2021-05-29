using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAWS.Models
{
    interface ISubject //implementirat ce KorisnikController. Potrebno jos dodati RealSubject I Proxy, kako?
    {
        public void PromijeniEmail(string noviEmail);
    }
}
