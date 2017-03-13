using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._3
{
    class Pilkarz:Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz(string imie_,string nazwisko_,string dataUrodzenia_, string pozycja_, string klub_):base(imie_,nazwisko_,dataUrodzenia_)
        {
            pozycja = pozycja_;
            klub = klub_;    
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imię: {0}, Nazwisko: {1}, Data Urodzenia: {2}\nKlub: {3}, Pozycja: {4}, Liczba bramek: {5}", imie, nazwisko, dataUrodzenia, klub, pozycja,liczbaGoli);
        }

        public void StrzelGola()
        {
            liczbaGoli += 1;
        }
    }
}
