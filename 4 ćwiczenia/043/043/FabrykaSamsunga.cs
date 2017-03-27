using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043
{
    public class ObudowaSamsung : Fabryka.Obudowa
    { }
    public class EkranSamsung : Fabryka.Ekran
    { }

    public class FabrykaSamsunga : Fabryka.FabrykaAbstrakcyjna
    {
        //Galaxy S5

     
        public override Fabryka.Obudowa WyprodukujObudowe()
        {
            var obudowa = new ObudowaSamsung();
            obudowa.Grubosc = 8.1;
            obudowa.Wysokosc = 72.5;
            obudowa.Szerokosc = 142;
            obudowa.Kolor = "Czarny";
            return obudowa;
        }
        public override Fabryka.Ekran WyprodukujEkran()
        {
            var ekran = new EkranSamsung();
            ekran.Wielkosc = 5.1;
            return ekran;
        }
    }
}
