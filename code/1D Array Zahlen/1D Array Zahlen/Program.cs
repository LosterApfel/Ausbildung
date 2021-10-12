using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_Array_Zahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Zahl = new int[4];
            int b = 0;

            for (int i = 0; i < 4; i++) ;
            {
                Zahl[b] = b += 10;

            }
            for (int c = 0; c < 4; c++) ;

            {
                Console.WriteLine(Zahl[b]);
            }

            Console.ReadKey();
        }


        
    }
}
