using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student("Radosław", "Matematyczny", "1991-03-27", 3, 2, 115623);
            PilkarzReczny Pierwszy = new PilkarzReczny("Janusz", "Kamilak", "1993-05-05", "obrotowy", "Warmia Olsztyn");
            Pierwszy.StrzelGola();
            Pierwszy.StrzelGola();
            Pierwszy.WypiszInfo();
            S.DodajOcene("Matematyka", DateTime.Now.ToString(), 5);
            S.DodajOcene("Matematyka", DateTime.Now.ToString(), 3);
            S.DodajOcene("Chemia", DateTime.Now.ToString(), 4);
            S.DodajOcene("Fizyka", "2017-03-13", 3.5);

            Console.WriteLine();
            S.WypiszInfo();
            //S.WypiszOceny();

            //S.WypiszOceny("Matematyka");
            // S.UsunOceny();
            // S.WypiszOceny("Matematyka");
            S.UsunOceny("Matematyka");
            S.WypiszOceny();
            S.UsunOcene("Fizyka", "2017-03-12", 3.5);

            Console.ReadKey();
        }
    }
}
