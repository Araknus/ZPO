using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Konto> konta = new List<Konto>
            {
            new Konto("Jan", "Kowalski", 11142, 900, 1),
            new Konto("Zbigniew", "Bilski", 68921, 1800, 2),
            new Konto("Maciej", "Urbanowicz", 56181, 2600, 3)
            };
            konta[0].WpłaćPieniądze(150);
            konta[1].ZmieńFunduszeKonta(5);
            konta[2].ZmieńStatusDoUsunięcia(false);

            Console.WriteLine(konta[0].ToString());
            Console.WriteLine(konta[1].ToString());
            Console.ReadKey();
            
            
        }
    }
}
