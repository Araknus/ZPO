using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043
{
    public class Fabryka
    {
        public abstract class Obudowa
        {
            public double Wysokosc { get; set; }
            public double Szerokosc { get; set; }
            public double Grubosc { get; set; }
            public string Kolor { get; set; }
        }

        public abstract class Ekran
        {
            public double Wielkosc { get; set; }
        }

        public abstract class FabrykaAbstrakcyjna
        {
            public abstract Obudowa WyprodukujObudowe();
            public abstract Ekran WyprodukujEkran();

        }

        //private Obudowa _obudowa;
        //private Ekran _ekran;
        //private string _nazwa;

        //public void ZlozSamsunga()
        //{
        //    var fabrykaSamsunga = new FabrykaSamsunga();
        //    _ekran = fabrykaSamsunga.WyprodukujEkran();
        //    _obudowa = fabrykaSamsunga.WyprodukujObudowe();
        //    _nazwa = "Samsung Galaxy S5";
            
            
        //}

        //public void ZlozApple()
        //{
        //    var fabrykaApple = new FabrykaApple();
        //    _ekran = fabrykaApple.WyprodukujEkran();
        //    _obudowa = fabrykaApple.WyprodukujObudowe();
        //    _nazwa = "iPhone S6";
            
        //}
    }
}
