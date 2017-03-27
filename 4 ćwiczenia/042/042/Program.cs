using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042
{
    class Program
    {
        static void Main(string[] args)
        {
            var z1 = new ZwyklyTelefon();
            var s1 = new Smartphone(z1);
            s1.PlayMarket();
            s1.RozmowaWideo();
            s1.WybierzNumer(231231512);
            s1.WyslijWiadomosc(23123123, "Witam. Idziemy na piwo dziś?");
            s1.PokazTyp();
            z1.PokazTyp();
            Console.ReadKey();


        }
    }
}
