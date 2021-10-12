using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_Array_mit_5_Variabeln
{
    class Program
    {
        static void Main()
        {
            int[] Zahl = new int[5];
            int b = 0;
            for (int i = 0; i < 500; i++)
            {
                Zahl[i] = b += 10;
                Console.WriteLine(Zahl[i]);

            }
            Console.ReadKey();
        }





    }
}
