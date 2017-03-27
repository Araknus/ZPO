using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041
{
    public sealed class Uczelnia
    {
        public string Nazwa { get; private set; }
        public DateTime DataRekrutacji { get; private set; }

        private static Uczelnia _Instance = null;
        private static readonly object _oPadLock = new object();



        private Uczelnia(string nazwa, DateTime dataRekrutacji)
        {
            Nazwa = nazwa;
            DataRekrutacji = dataRekrutacji;
        }

        public static Uczelnia Instance(string nazwa, DateTime data)
        {

            if (_Instance == null)
            {
                lock (_oPadLock)
                {
                    if(_Instance == null)
                    _Instance = new Uczelnia(nazwa, data);
                    return _Instance;
                }
            }
            _Instance.Nazwa = nazwa;
            _Instance.DataRekrutacji = data;
            return _Instance;
        }

        public string RekrutujStudentow()
        {
            return "Nazwa uczelni: " + Nazwa + " Data rekrutacji: " + DataRekrutacji.ToShortDateString();
        }


                
            
    }
    

}
