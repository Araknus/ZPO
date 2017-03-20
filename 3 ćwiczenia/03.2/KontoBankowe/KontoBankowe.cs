using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoBankowe
{
    public class KontoBankowe
    {
        int Numerkonta;
        double Saldo;

        public double Incash(KontoBankowe nrkonta, double wartosc)
        {
            Saldo += wartosc;
            return Saldo;
        }
        public double Outcash(KontoBankowe nrkonta, double wartosc)
        {
            Saldo -= wartosc;
            return Saldo;
        }
        public double Checkcash(KontoBankowe nrkonta)
        {
            return Saldo;
        }
        public double Transfercash(KontoBankowe nrzkonta, KontoBankowe nrdokonta, double wartosc)
        {
            return 0;
        }

        public KontoBankowe(int numerkonta, double saldostart)
        {
            Numerkonta = numerkonta;
            Saldo = saldostart;
        }

        KontoBankowe pierwsze = new KontoBankowe(1111,1950);
        KontoBankowe drugie = new KontoBankowe(2222,2235);

    }
}
