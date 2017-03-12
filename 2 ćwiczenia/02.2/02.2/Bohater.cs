using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._2
{
    abstract class Bohater:IBohater
    {
        public int Hp;
        public int Atak;
        protected Rasa rasa;
        public string Nazwa;

        public enum Rasa
        {
            Krasnolud,
            Elf,
            Ork,
            Człowiek
        }



        public Bohater(string nazwa, int hp, int atak, Rasa rasa)
        {
            Nazwa = nazwa;
            Hp = hp;
            Atak = atak;
            this.rasa = rasa;
        }

        public void BijWroga(Bohater obiekt)
        {
            if(obiekt.Hp>0)
            {
                obiekt.Hp -= Atak;
                Console.WriteLine("{0} zaatakował {1} i zabrał mu {2} punktów życia", Nazwa, obiekt.Nazwa, Atak);
            }
            else
            {
                Console.WriteLine("Postać {0} nie żyje", obiekt.Nazwa);
            }

        }

        public string SprawdzHp()
        {   
            if(Hp>0)
            {
                return String.Format("Ilość punktów życia postaci {0} klasy {1}:  {2}", Nazwa, this.GetType().Name, Hp);
            }
            else
            {
                return String.Format("Postać {0} nie żyje", Nazwa);
            }
            
        }

    }
    
}
