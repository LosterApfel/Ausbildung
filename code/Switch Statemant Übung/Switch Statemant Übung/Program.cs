using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statemant_Übung
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Gib eine Zahl zwischen 1 und 12 ein :) ");
            int Zahl = Convert.ToInt32(Console.ReadLine()); ;
            switch (Zahl)
            {
                case 1:
                    Console.WriteLine("Januar");
                    break;

                case 2:
                    Console.WriteLine("Februar");
                    break;
                case 3:
                    Console.WriteLine("März");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("Mai");
                    break;

                case 6:
                    Console.WriteLine("Juni");
                    break;

                case 7:
                    Console.WriteLine("Juli");
                    break;

                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine("Oktober");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("Dezember");
                    break;

                default:
                    Console.WriteLine("Es gibt nur 12 Monate :) ");
                    break;


            }
            Console.ReadKey();
        }
    } 
}
