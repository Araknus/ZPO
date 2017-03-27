using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041
{
    class Program
    {
        static void Main(string[] args)
        {
            var UWM = Uczelnia.Instance("UWM",new DateTime(2017, 06, 15));
            var Stanford =Uczelnia.Instance("Stanford",new DateTime(2017, 06, 30));



            Console.WriteLine(UWM.RekrutujStudentow());
            Console.WriteLine(Stanford.RekrutujStudentow());

            Console.ReadKey();

        }

        
    }
}
