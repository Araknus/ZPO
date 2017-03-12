using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._2
{
    class Wojownik:Bohater
    {
        public Wojownik(string nazwa,int hp, int atak, Rasa rasa):base(nazwa,hp,atak,rasa)
        {
        }

        public void RzutToporem(Bohater obiekt)
        {
            if (obiekt.Hp > 0)
            {
                obiekt.Hp -= 25;
                Console.WriteLine("{0} rzucił toporem w {1} i zabrał mu 25 punktów życia", Nazwa, obiekt.Nazwa);
            }
            else
            {
                Console.WriteLine("Postać {0} nie żyje", obiekt.Nazwa);
            }
        }
    }
}
