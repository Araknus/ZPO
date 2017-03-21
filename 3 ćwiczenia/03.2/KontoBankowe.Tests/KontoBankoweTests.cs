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
            double result1 = op1.Checkcash();
            double result2 = op1.Incash(500);
            double result3 = op1.Outcash(400);
            double result4 = op1.Transfercash(op2,300);
            double result6 = op1.Checkcash();

            Assert.AreEqual(4450, result1);
            Assert.AreEqual(4950, result2);
            Assert.AreEqual(4550, result3);
            Assert.AreEqual(9300, result4);
            Assert.AreEqual(4250, result6);
            Assert.Throws<ArgumentOutOfRangeException>(() => op1.Outcash(5000));
            Assert.Throws<ArgumentOutOfRangeException>(() => op1.Transfercash(op2,6000));



        }
        

    }
}
