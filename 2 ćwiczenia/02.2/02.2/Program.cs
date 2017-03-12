using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rzezimieszek DP1 = new Rzezimieszek("Rudolf",100,20,Bohater.Rasa.Krasnolud,20);
            Mag DP2 = new Mag("Maxym",70, 10, Bohater.Rasa.Człowiek, 80);
            Wojownik DP3 = new Wojownik("Zygmunt", 130, 40, Bohater.Rasa.Człowiek);

            Rzezimieszek O1 = new Rzezimieszek("Umbrat", 50, 10, Bohater.Rasa.Ork, 20);
            Mag O2 = new Mag("Korhul", 80, 10, Bohater.Rasa.Ork, 100);
            Wojownik O3 = new Wojownik("Turshak", 150, 40, Bohater.Rasa.Ork);


            List<Bohater> Drużyna_Pierścienia = new List<Bohater>();
            
                Drużyna_Pierścienia.Add(DP1);
                Drużyna_Pierścienia.Add(DP2);
                Drużyna_Pierścienia.Add(DP3);

            List<Bohater> Urukhai = new List<Bohater>();

                Urukhai.Add(O1);
                Urukhai.Add(O1);
                Urukhai.Add(O1);

            DP1.BijWroga(O2);
            DP2.RzucCzar(O2);
            DP3.BijWroga(O2);
            Console.WriteLine(O2.SprawdzHp());
            O1.BijWroga(DP3);
            O3.RzutToporem(DP2);
            DP1.BijWroga(O1);
            DP2.RzucCzar(O1);
            DP3.RzutToporem(O1);
            O3.BijWroga(DP1);
            DP1.BijWroga(O3);
            DP2.BijWroga(O3);
            DP3.BijWroga(O3);
            O3.BijWroga(DP1);
            DP1.BijWroga(O3);
            DP2.RzucCzar(O3);
            DP3.BijWroga(O3);
            Console.WriteLine(O3.SprawdzHp());
            Console.WriteLine(DP1.SprawdzHp());
            Console.WriteLine(DP2.SprawdzHp());
            Console.WriteLine(DP3.SprawdzHp());




            Console.ReadKey();
        }
    }
}
