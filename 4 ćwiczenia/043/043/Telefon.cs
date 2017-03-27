using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043
{

    public class Telefon
    {
        private Fabryka.Obudowa _obudowa;
        private Fabryka.Ekran _ekran;

        public Telefon(Fabryka.FabrykaAbstrakcyjna fabrykaTelefonu)
        {
            _obudowa = fabrykaTelefonu.WyprodukujObudowe();
            _ekran = fabrykaTelefonu.WyprodukujEkran();
        }

        public override string ToString()
        {
            return " Obudowa telefonu. Wysokość: " + _obudowa.Wysokosc + " Szerokość: " + _obudowa.Szerokosc + " Grubość: " + _obudowa.Grubosc;
        } 
    }
}
