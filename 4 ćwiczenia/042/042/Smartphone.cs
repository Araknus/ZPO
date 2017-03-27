using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042
{
    class Smartphone:Dekorator
    {
        private string rt;
        public Smartphone(ZwyklyTelefon zwyklytelefon, string rodzajtelefonu="smartphone" ):base(zwyklytelefon)
        { 
            this.rt = rodzajtelefonu;
        }

        public void PlayMarket()
        {
            Console.WriteLine("Włączone Google Play Market");
        }

        public void RozmowaWideo()
        {
            Console.WriteLine("Włączono tryb - rozmowa wideo");
        }

        public void PokazTyp()
        {
            Console.WriteLine("Typ telefonu to: {0}",rt);
        }
    }
}
