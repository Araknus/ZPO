using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    class Obecnosc
    {
        string Przedmiot;
        bool Obecny;

        public Obecnosc(string przedmiot, bool obecny)
        {
            Przedmiot = przedmiot;
            Obecny = obecny;
        }
    }
}
