using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043
{
    public class ObudowaApple : Fabryka.Obudowa
    { }
    public class EkranApple : Fabryka.Ekran
    { }

    public class FabrykaApple:Fabryka.FabrykaAbstrakcyjna
    {
        //iPhone 6s

        public override Fabryka.Obudowa WyprodukujObudowe()
        {
            var obudowa = new ObudowaApple();
            obudowa.Grubosc = 7.1;
            obudowa.Wysokosc = 67.1;
            obudowa.Szerokosc = 138.3;
            obudowa.Kolor = "Biały";
            return obudowa;
        }
        public override Fabryka.Ekran WyprodukujEkran()
        {
            var ekran = new EkranApple();
            ekran.Wielkosc = 5.5;
            return ekran;
        }
    }
}

