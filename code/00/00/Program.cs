using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Willkommen such dir ne Zahl zwischen 1 und 5 aus. Viel Spaß :)");
            int Zahl = int.Parse(Console.ReadLine());
            switch (Zahl)
            {
                case 1:
                    Console.WriteLine("Hallo willkommen bei der 1 :) ");
                    break;
                case 2:
                    Console.WriteLine("Hallo willkommen bei der 2 :) ");
                    break;
                case 3:
                    Console.WriteLine("Hallo willkommen bei der 3 :) ");
                    break;
                case 4:
                    Console.WriteLine("Hallo willkommen bei der 4 :) ");
                    break;
                default:
                    Console.WriteLine("Es gibt nur 4 du pissa :) ");
                    break;

            }
            Console.ReadKey();
        }   
        
    }
}
