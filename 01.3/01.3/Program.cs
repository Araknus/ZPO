using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            

            List<StandardowyCzłowiek> ludzie = new List<StandardowyCzłowiek>
            {
            new StandardowyCzłowiek("Maciej",24,206,"Olsztyn",23),
            new StandardowyCzłowiek("Iwona",23,206,"Gdańsk",23),
            new StandardowyCzłowiek("Tomasz",30,206,"Morąg",23),
            new StandardowyCzłowiek("Sebastian",16,206,"Morąg",24),
            new StandardowyCzłowiek("Sebastian",38,206,"Olsztyn",23)
            };
            Console.WriteLine("Imiona obiektów");
            for (int i = 0; i < ludzie.Count(); i++)
            {
                suma += ludzie[i].Wiek;
                Console.WriteLine(ludzie[i].Imie);
            }
            var srednia = suma / ludzie.Count();

            var miasta = ludzie
                                    .GroupBy(q => q.MiejscePochodzenia)
                                    .OrderByDescending(gp => gp.Count()).First().Key;

            Console.WriteLine();
            Console.WriteLine("Średnia wieku wynosi {0}", srednia);
            Console.WriteLine("Uniwersalne dane dla każdego człowieka to ich liczba kości - {0}",ludzie[0].IlośćKościSzkieletowych);
            Console.WriteLine(miasta);
            Console.ReadKey();


        }
    }
}
