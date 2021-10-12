using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Übungsaufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Zahlenliste = { 1, 3, 5, 4, 7, 8, 9, 10, 6, 2, 3, 4 };

            Array.Sort(Zahlenliste);

            foreach (int zahl in Zahlenliste)
            {
                Console.WriteLine(zahl);
            }
            Console.ReadKey();
        }
    }

}