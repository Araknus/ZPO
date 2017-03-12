using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ISamochod> samochody = new List<ISamochod>();
            samochody.Add(new RollsRoyce());
            samochody.Add(new RangeRover());
            samochody.Add(new AstonMartin());

            samochody.ForEach(samochod =>
            {
                Console.WriteLine("{0} | {1}", samochod.WypiszMarke(), samochod.WypiszSalon());
            });
            Console.ReadKey();
        }
    }
}
