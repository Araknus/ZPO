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
            var op1 = new KontoBankowe(3333,4450);
            var op2 = new KontoBankowe(4444, 9000);
            double result1 = op1.Checkcash(op1);
            double result2 = op1.Incash(op1,500);
            double result3 = op1.Outcash(op1,500);
            double result4 = op1.Transfercash(op1,op2,300);

        }
        

    }
}
