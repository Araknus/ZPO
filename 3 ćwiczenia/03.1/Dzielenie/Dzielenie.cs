using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzielenie
{
    public class Dzielenie
    {
        public Double DivideNumbers(double a, double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();
            return a / b;
        }
    }
}
