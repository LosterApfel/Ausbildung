using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case_Übung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib ne Zahl von 1 bis 12 ein");
            int Zahl = int.Parse(Console.ReadLine());
            switch (Zahl)
            {
                case 1:
                    Console.WriteLine("Moin");
                    break;
                case 2:
                    Console.WriteLine("Moiiiinnnnn du pissa");
                    break;
                case 3:
                    Console.WriteLine("Moin");
                    break;
                case 4:
                    Console.WriteLine("Moiiiinnnnn du pissa");
                    break;
                case 5:
                    Console.WriteLine("Moin");
                    break;
                case 6:
                    Console.WriteLine("Moiiiinnnnn du pissa");
                    break;
                case 7:
                    Console.WriteLine("Moin");
                    break;
                case 8:
                    Console.WriteLine("Moiiiinnnnn du pissa");
                    break;
                case 9:
                    Console.WriteLine("Moin");
                    break;
                case 10:
                    Console.WriteLine("Moiiiinnnnn du pissa");
                    break;
                case 11:
                    Console.WriteLine("Moin");
                    break;
                case 12:
                    Console.WriteLine("Moiiiinnnnn du pissa");
                    break;
                default:
                    Console.WriteLine("es gibt nur eins und zwölf");
                    break;
            }
            Console.ReadKey();
        }
    }
}
