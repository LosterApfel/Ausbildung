using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zusatzaufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie an ob ungerade (1) oder gerade (2) Zahlen angegeben werden sollen");
            string input = Console.ReadLine();
            int D = Convert.ToInt32(input);
            int zahl = 0;
            switch (D)
            {
                case 1:
                    do
                    {
                        if (zahl % 2 != 0)
                        {
                            Console.WriteLine(zahl);
                        }
                        zahl += 1;
                    }
                    while (zahl <= 100);
                    break;
                case 2:
                    do
                    {
                        if (zahl % 2 == 0)
                        {
                            Console.WriteLine(zahl);
                        }
                        zahl += 1;
                    }
                    while (zahl <= 100);
                    break;
            }
            Console.ReadKey();
        }
    }
}