using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Samochod> samochody = new List<Samochod>
            {
            new Samochod("Opel Astra", 4, 80, "Biały", 2015),
            new Samochod("Toyota Corolla", 4, 90, "Srebrna", 2004),
            new Samochod("VW Golf 4", 4, 70, "Czerwony", 2002)
            };
            samochody[1].Hamuj();
            foreach ( var ten in samochody)
            {
                samochody[1].Jedz(90);


                Console.WriteLine("{0} samochód marki {1} jedzie z prędkością {2}",ten.Kolor,ten.Marka,ten.Predkosc);
                Console.WriteLine("Domyślna ilość kół używanych jednocześnie w samochodzie to {0}", ten.LiczbkaKol);
                Console.ReadKey();
            }

        }
    }
}
