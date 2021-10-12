using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_Switch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Geben sie 1 oder 2 ein :) ");
            int Test = Convert.ToInt32(Console.ReadLine());
            while (Test == 1 || Test == 2)
            {
                int Zahl = Convert.ToInt32(Console.ReadLine());
                switch (Zahl)
                
                {
                    //case 1
                    case 1:
                        Console.WriteLine("Hallo du hast die 1 gewält");
                        break;

                    //case 2
                    case 2:
                        Console.WriteLine("Hey du hast die 2 gewählt");
                        break;

                   // default 
                     default:
                        Console.WriteLine("Es gibt nur 1 und 2 :)");
                        break;

                  

                }
            }
            Console.ReadKey();
        }
    }
}
