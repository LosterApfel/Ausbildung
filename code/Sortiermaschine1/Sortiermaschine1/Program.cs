using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortiermaschine1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Sortierte Zahlen :)");
            int[] Zahlen = { 5, 3, 6, 8, 4, 9 };
            int h = 0;
            for (int i = 0; i < Zahlen.Length - 1; i++)
            {
                for (int j = 0; j < Zahlen.Length; j++)
                {
                    {
                        if (Zahlen[j] > Zahlen[j + 1])
                   
                        h = Zahlen[j + 1];
                        Zahlen[j + 1] = Zahlen[j];
                        Zahlen[j] = h;


                    }
                    Console.WriteLine("Sorted:");
                    foreach (int k in Zahlen)
                    {
                        Console.WriteLine(k);
                    }
                    Console.ReadKey();



                }




                



            }
        }
    }
}
