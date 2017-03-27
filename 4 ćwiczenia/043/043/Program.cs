using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Fabryka.FabrykaAbstrakcyjna samsung = new FabrykaSamsunga();
            Fabryka.FabrykaAbstrakcyjna apple = new FabrykaApple();

            Telefon moj = new Telefon(samsung);
            Telefon twoj = new Telefon(apple);
            Console.WriteLine(moj.ToString());
            Console.WriteLine(twoj.ToString());

            Console.ReadKey();

        }
    }
}
