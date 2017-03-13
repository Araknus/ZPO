using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._3
{
    class Ocena
    {
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public Ocena(string nazwaPrzedmiotu_,string data_, double wartosc_)
        {
            nazwaPrzedmiotu = nazwaPrzedmiotu_;
            data = data_;
            wartosc = wartosc_;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Nazwa przedmiotu: {0}, Ocena:{1}",nazwaPrzedmiotu,wartosc);
        }

        public bool CzyIdentyczne(string nazwaPrzedmiotu)
        {
            return this.nazwaPrzedmiotu.Equals(nazwaPrzedmiotu);
        }

        public bool CzyIdentyczne(string nazwaPrzedmiotu, string data, double wartosc)
        {
            return (this.nazwaPrzedmiotu.Equals(nazwaPrzedmiotu)&&this.data.Equals(data)&&this.wartosc.Equals(wartosc));
        }
    }
}
