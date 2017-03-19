using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Dzielenie.Tests
{
    [TestFixture]
    public class DzielenieTests
    {
      
        [Test]
        public void Dzielenie_2liczb()
        {
            var calc = new Dzielenie();
            double wynik = calc.DivideNumbers(2, 2);

            Assert.AreEqual(1, wynik);
            Assert.AreEqual(4, calc.DivideNumbers(8, 2));
            
        }
    }
}
