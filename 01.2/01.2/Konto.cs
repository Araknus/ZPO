using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2
{
    class Konto
    {
        private string _imie { get; set; }
        private string _nazwisko { get; set; }
        private int _numerKonta { get; set; }
        private int _fundusze { get; set; }
        private int _wewId { get; set; }
        private bool _doUsuniecia { get; set; }


        public Konto(string imie,string nazwisko,int numerKonta,int fundusze, int wewId, bool doUsuniecia=false)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _numerKonta = numerKonta;
            _fundusze = fundusze;
            _wewId = wewId;
            _doUsuniecia = doUsuniecia;


        }

        public void WpłaćPieniądze(int ilosc)
        {
            _fundusze += ilosc;
        }

        public void WypłaćPieniądze(int ilosc)
        {
            _fundusze -= ilosc;
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
            _fundusze += _fundusze*procent/100;
        }

        public override string ToString()
        {
            return  "Użytkownik konta " + _imie.ToString() +" " + _nazwisko.ToString() + " ma " + _fundusze.ToString() +" zł na koncie";
        }

    }
}
