using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042
{
    class ZwyklyTelefon:ITelefon
    {
        public void WybierzNumer(int numer)
        {
            Console.WriteLine("Wybrano numer {0}", numer);
        }

        public void WyslijWiadomosc(int numer, string wiadomosc)
        {
            Console.WriteLine("Wysyłam wiadomość o treści: \"{0}\" na numer {1}", wiadomosc, numer);
        }

        public void PokazTyp()
        {
            Console.WriteLine("Typ telefonu to: zwykły telefon");
        }
    }
}
