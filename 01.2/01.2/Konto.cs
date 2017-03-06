using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2
{
    class Konto
    {
        private string Imie { get; set; }
        private string Nazwisko { get; set; }
        private int NumerKonta { get; set; }
        private int Fundusze { get; set; }
        private int WewId { get; set; }
        private bool DoUsuniecia { get; set; }


        public Konto(string imie,string nazwisko,int numerKonta,int fundusze, int wewId, bool doUsuniecia=false)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            NumerKonta = numerKonta;
            Fundusze = fundusze;
            WewId = wewId;
            DoUsuniecia = doUsuniecia;


        }

        public void WpłaćPieniądze(int ilosc)
        {
            Fundusze += ilosc;
        }

        public void WypłaćPieniądze(int ilosc)
        {
            Fundusze -= ilosc;
        }

        public void UsuńKonto(List<Konto> lista, int id)
        {
            lista.RemoveAt(id);
        }

        public void ZmieńStatusDoUsunięcia(bool status)
        {
            status = true;
        }


        public void ZmieńFunduszeKonta(int procent)
        {
            Fundusze += Fundusze*procent/100;
        }

        public override string ToString()
        {
            return  "Użytkownik konta " + Imie.ToString() +" " + Nazwisko.ToString() + " ma " + Fundusze.ToString() +" zł na koncie";
        }

    }
}
