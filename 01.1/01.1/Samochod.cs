using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1
{
    class Samochod
    {
        public string Marka { get; private set; }
        public int LiczbkaKol { get; private set; }
        public int Predkosc { get; private set; }
        public string Kolor { get; private set; }
        public int Rocznik { get; private set; }

        public Samochod(string marka,int liczbaKol, int predkosc, string kolor = "Czarny",int rocznik = 2016 )
        {
            Marka = marka;
            LiczbkaKol = liczbaKol;
            Predkosc = predkosc;
            Kolor = kolor;
            Rocznik = rocznik;
        }

        public void Jedz(int v1)
        {
            Predkosc = v1;
        }

        public void Hamuj ()
        {
            Predkosc = 0;
           


        }
    }
}
