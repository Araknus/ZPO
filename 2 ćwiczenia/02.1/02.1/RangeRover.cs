using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._1
{
     class RangeRover : ISamochod

    {

        public string WypiszMarke()
        {
            return String.Format("Marka {0}", this.GetType().Name);
        }

        public string WypiszSalon()
        {
            return String.Format("Salon {0}", this.GetType().Name);
        }
    }
}
