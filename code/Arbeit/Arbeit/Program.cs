using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeit
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ganzzahl = int.Parse(Console.ReadLine());
            int Teilerzahl = 0;
            int Laufvariabel = 1;
            while (Laufvariabel <= Ganzzahl)
            {
                if (Ganzzahl % Laufvariabel == 0) 
                {
                    Teilerzahl++;
                }


                Laufvariabel++;
            }
                


                if (Teilerzahl==2)
                {
                    Console.WriteLine("Das ist eine Primzahl");
                }
                else
                {
                    Console.WriteLine("Das ist keine Primzahl");
                }
            Console.ReadKey();


        }
        
        
    }
    
}
