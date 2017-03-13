using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._3
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba(string imie_, string nazwisko_, string dataUrodzenia_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            dataUrodzenia = dataUrodzenia_;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imię: {0}, Nazwisko: {1}, Data Urodzenia: {2}", imie, nazwisko, dataUrodzenia);
        }
    }
}
