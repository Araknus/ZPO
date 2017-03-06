using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3
{
    class StandardowyCzłowiek
    {

        public string Imie { get; set; }
        public int Wiek { get; set; }
        public int IlośćKościSzkieletowych { get; set; }
        public string MiejscePochodzenia { get; set; }
        public int IlośćChromosomów { get; set; }


        public StandardowyCzłowiek(string imie, int wiek, int ilośćKościSzkieletowych, string miejscePochodzenia, int ilośćChromosomów)
        {
            Imie = imie;
            Wiek = wiek;
            IlośćKościSzkieletowych = ilośćKościSzkieletowych;
            MiejscePochodzenia = miejscePochodzenia;
            IlośćChromosomów = ilośćChromosomów;

        }
    }
}
