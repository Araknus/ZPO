using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042
{
    class Dekorator:ITelefon
    {
        protected ITelefon _itelefon;

        public Dekorator(ITelefon itelefon)
        {
            _itelefon = itelefon;
        }

        public  void WybierzNumer(int numer)
        {
            _itelefon.WybierzNumer(numer);
        }

        public void WyslijWiadomosc(int numer, string wiadomosc)
        {
            _itelefon.WyslijWiadomosc(numer,wiadomosc);
        }

        public void PokazTyp()
        {
            _itelefon.PokazTyp();
        }
    }
}
