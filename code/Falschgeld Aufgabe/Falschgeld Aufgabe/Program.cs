using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Seriennummer = new string[12];
            int[] SerienINT = new int[12];

            Console.WriteLine("Geben Sie die Seriennummer der Banknote nacheinander ein (mit dem führenden Buchstabe) und quitieren Sie die Eingabe mit ENTER");

            int t = 1;                     //muss außerhalb der for Schleife deklariert werden, sonst wird sie bei jedem Schleifendurchgang wieder auf 1 gesetzt.

            for (int i = 0; i <= 11; i++)
            {

                if (t <= 12)            // kosmetische Eingabe-Begleitung
                {
                    Console.WriteLine("Bitte das " + t + " Zeichen eingeben: ");
                    t++;
                }

                Seriennummer[i] = Console.ReadLine();

            }

            int Prüfziffer = int.Parse(Seriennummer[11]);


            switch (Seriennummer[0])
            {
                case "A":
                    Seriennummer[0] = "1";
                    break;

                case "B":
                    Seriennummer[0] = "2";
                    break;

                case "C":
                    Seriennummer[0] = "3";
                    break;
                default:
                    Console.WriteLine("Sie haben bei der Eingabe einen Fehler gemacht");
                    break;
            }

            for (int j = 0; j < 11; j++)
            {
                SerienINT[j] = int.Parse(Seriennummer[j]);

            }

            int Quersumme = 0;

            for (int l = 0; l < 10; l++)       //Quersummer ohne Prüfziffer
            {
                Quersumme = Quersumme + SerienINT[l];

            }
            Console.WriteLine("Die Quersumme ist: " + Quersumme);
            Console.WriteLine("Die Prüfziffer ist: " + Prüfziffer);

            int Neunerrest;
            Neunerrest = Quersumme % 9;
            Console.WriteLine("Der Neunerrest ist: " + Neunerrest);
            int Ziffer = 8 - Neunerrest;

            Console.WriteLine("Die ermittelte Ziffer ist: " + Ziffer);

            if (Ziffer == 0)
            {
                if (Prüfziffer == 9)
                {
                    Console.WriteLine("Der Schein ist NICHT gefälscht");

                }
                else
                {
                    Console.WriteLine("Es liegt eine Fälschung vor");
                }
            }
            else
            {
                if (Prüfziffer == Ziffer)
                {
                    Console.WriteLine("Der Schein ist NICHT gefälscht");
                }
                else
                {
                    Console.WriteLine("Es liegt eine Fälschung vor");
                }
            }
            Console.ReadKey();
        }



    }
}
