using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._2
{
    class Mag:Bohater
    {
        public int Mana;

        public Mag(string nazwa,int hp, int atak, Rasa rasa, int mana):base(nazwa,hp,atak,rasa)
        {
            Mana = mana;
        }
        public void RzucCzar(Bohater obiekt)
        {
            if(obiekt.Hp>0)
            {
                if (Mana >= 20)
                {
                    this.Mana -= 20;
                    obiekt.Hp -= 40;
                    Console.WriteLine("{0} rzucił czar na {1} i zabrał mu 40 punktów życia", Nazwa, obiekt.Nazwa);
                }
                else
                {
                    Console.WriteLine("Za mało many by {0} rzucił czar", Nazwa);
                }


            }
            else
            {
                Console.WriteLine("Postać {0} nie żyje", obiekt.Nazwa);
            }


        }
    }
}
