using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Geben Sie bitte die Rechte der jeweiligen Nutzer an");
            string Rechte = Console.ReadLine();

            int[] ArrayDZ = new int[9];
            ArrayDZ = EINoNULL(Rechte);

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(ArrayDZ[i]);
            }

            Console.ReadKey();
        }

        static int[] EINoNULL(string Zeichen)
        {
            int[] Dualzahl = new int[9];

            for (int i = 0; i <= 8; i++)
            {
                switch (Zeichen[i])
                {
                    case '-':
                        Dualzahl[i] = 0;
                        break;
                    default:
                        Dualzahl[i] = 1;
                        break;
                }
            }
            return Dualzahl;
        }
    }
}
