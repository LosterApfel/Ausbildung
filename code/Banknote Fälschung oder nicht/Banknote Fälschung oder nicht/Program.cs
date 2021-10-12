using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main()
        {
            string[] Seriennummer = new string[12];

            Console.WriteLine("Geben Sie die Seriennummer der Banknote nacheinander ein (mit dem führenden Buchstabe) und quitieren Sie die Eingabe mit ENTER");

            for (int i = 0; i < 12; i++)
            {
                Seriennummer[i] = Console.ReadLine();
            }


            switch (Seriennummer[0])
            {

                case "A":
                    {
                        Seriennummer[0] = "1";
                        break;
                    }
                case "B":
                    {
                        Seriennummer[0] = "2";
                        break;
                    }
                case "C":
                    {
                        Seriennummer[0] = "3";
                        break;
                    }
                case "D":
                    {
                        Seriennummer[0] = "4";
                        break;
                    }
                case "E":
                    {
                        Seriennummer[0] = "5";
                        break;
                    }
                case "F":
                    {
                        Seriennummer[0] = "6";
                        break;
                    }
                case "G":
                    {
                        Seriennummer[0] = "7";
                        break;
                    }
                case "H":
                    {
                        Seriennummer[0] = "8";
                        break;
                    }
            }

            int[] SerienINT = new int[12];


            for (int j = 0; j < 11; j++)
            {
                SerienINT[j] = int.Parse(Seriennummer[j]);

            }
            int Quersumme = 0;

            for (int i = 0; i <= 10; i++)
            {
                Quersumme = Quersumme + SerienINT[i];
            }

            int Neunerrest = Quersumme % 9;

            int Ziffer = 8 - Neunerrest;

            int Prüfziffer = SerienINT[11];

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























