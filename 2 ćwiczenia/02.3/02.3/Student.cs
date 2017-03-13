using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._3
{
    class Student:Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;

        public Student(string imie_,string nazwisko_,string dataUrodzenia_,int rok_,int grupa_,int nrIndeksu_):base(imie_,nazwisko_,dataUrodzenia_)
        {
            rok = rok_;
            grupa = grupa_;
            nrIndeksu = nrIndeksu_;
        }

        public List<Ocena> oc1 = new List<Ocena>();

        public void WypiszInfo()
        {
            Console.WriteLine("Imię: {0}, Nazwisko: {1}, Data Urodzenia: {2}\nRok: {3}, Grupa: {4}, Numer indeksu: {5}", imie, nazwisko, dataUrodzenia, rok, grupa, nrIndeksu);
        }

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            oc1.Add(new Ocena(nazwaPrzedmiotu,data,wartosc));
        }
        public void WypiszOceny()
        {
            foreach(Ocena oc in oc1)
            {
                oc.WypiszInfo();
            }
        }

        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            foreach (Ocena oc in oc1.Where(oc1 => oc1.CzyIdentyczne(nazwaPrzedmiotu)))
            {
                oc.WypiszInfo();
            }
        }

        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            for (int i = 0; i < oc1.Count(); i++)
            {
                if (oc1[i].CzyIdentyczne(nazwaPrzedmiotu,data,wartosc))
                {
                    oc1.Remove(oc1[i]);
                    i--;
                }
            }

        }

        public void UsunOceny()
        {
            oc1.Clear();
        }

        public void UsunOceny(string nazwaPrzedmiotu)
        {
            for(int i=0; i<oc1.Count();i++)
            {
                if(oc1[i].CzyIdentyczne(nazwaPrzedmiotu))
                {
                    oc1.Remove(oc1[i]);
                    i--;
                }
            }
            
        }



    }
}
