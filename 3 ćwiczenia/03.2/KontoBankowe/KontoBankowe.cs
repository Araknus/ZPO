using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoBankowe
{
    public class KontoBankowe
    {
        public int Numerkonta { get; set; }
        private double Saldo { get; set; }

        public double Incash(double wartosc)
        {
            Saldo += wartosc;
            return Saldo;
        }
        public double Outcash(double wartosc)
        {
            Saldo -= wartosc;
            return Saldo;
        }
        public double Checkcash()
        {
            return Saldo;
        }
        public double Transfercash(KontoBankowe nrdokonta, double wartosc)
        {
            Saldo -= wartosc;
            nrdokonta.Saldo += wartosc;
            return nrdokonta.Saldo;
        }

        public KontoBankowe(int numerkonta, double saldostart)
        {
            Numerkonta = numerkonta;
            Saldo = saldostart;
        }

        

    }
}
