using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KontoBankowe.Tests
{
    [TestFixture]
    public class KontoBankoweTests
    {
        [Test]
        public void BankAccount()
        {
            var op = new KontoBankowe();
            double result1 = op.Checkcash(1111);
            double result2 = op.Incash(1111,500);
            double result3 = op.Outcash(1111,500);
            double result4 = op.Transfercash(1111,2222,300);

        }
        

    }
}
