using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederstandberechner
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Das Ergebnis ist: " + Berechnung(Werte(AnzahlWiderstände()), Entscheidung()));

            Console.ReadKey();
        }

        static int AnzahlWiderstände()
        {
            //int Anzahl = 0;
            Console.WriteLine("Bitte geben Sie an wie viele Widerstände im Stromkreis vorkommen");
            int Anzahl = int.Parse(Console.ReadLine());
            return Anzahl;
        }

        static double[] Werte(int Anzahl)
        {
            double[] Widerstände = new double[Anzahl];

            Console.WriteLine("Bitte geben Sie die Werte für die Widerstände ein:");

            for (int i = 0; i < Anzahl; i++)
            {
                Widerstände[i] = double.Parse(Console.ReadLine());
            }
            return Widerstände;
        }

        static char Entscheidung()
        {
            Console.WriteLine("Sind die Widerstände prallel oder in Reihe geschaltet? Geben Sie R für Reihe oder P für Parallel ein.");

            char ReihePara = char.Parse(Console.ReadLine());
            return ReihePara;

        }

        static double Berechnung(double[] Widerstände, char ReihePara)
        {
            double ErgebnisREIHE = 0;
            double ErgebnisPARA = 0;

            double Zwischensumme = 0;

            if (ReihePara == 'R')
            {
                foreach (double Widerstand in Widerstände)
                {
                    ErgebnisREIHE += Widerstand;
                }

                return ErgebnisREIHE;
            }
            else
            {
                foreach (double Widerstand in Widerstände)
                {
                    Zwischensumme += 1 / Widerstand;
                }

                ErgebnisPARA = 1 / Zwischensumme;
                return ErgebnisPARA;
            }

        }
    }
}
