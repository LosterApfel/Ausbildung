using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerade_und_Ungerade
{
    class Program
    {
        static void Main()
        {
            int Zähler = 0;
            Console.WriteLine("Welche Art von Zahl soll angegeben werden?");
            string input = Console.ReadLine();

            while (Zähler <= 100)
            {
                if (Zähler % 2 == 0 && input == "gerade")
                {
                    Console.WriteLine(Zähler + " ist eine gerade Zahl");

                }
                else if (Zähler % 2 == 1 && input == "ungerade")
                {
                    Console.WriteLine(Zähler + " ist eine ungerade Zahl");
                }

                Zähler++;
            }

            int Zähler2 = 0;
            Console.WriteLine("Welche Art von Zahl soll angegeben werden?");
            string input2 = Console.ReadLine();

            while (Zähler2 <= 100)
            {
                if (Zähler2 % 2 == 0 && input2 == "gerade")
                {
                    Console.WriteLine(Zähler2 + " ist eine gerade Zahl");

                }
                else if (Zähler2 % 2 == 1 && input2 == "ungerade")
                {
                    Console.WriteLine(Zähler2 + " ist eine ungerade Zahl");
                }

                Zähler2++;
            }
            int Zähler3 = 0;
            Console.WriteLine("Welche Art von Zahl soll angegeben werden?");
            string input3 = Console.ReadLine();

            while (Zähler3 <= 100)
            {
                if (Zähler3 % 2 == 0 && input3 == "gerade")
                {
                    Console.WriteLine(Zähler3 + " ist eine gerade Zahl");

                }
                else if (Zähler3 % 2 == 1 && input3 == "ungerade")
                {
                    Console.WriteLine(Zähler3 + " ist eine ungerade Zahl");
                }

                Zähler3++;

            }
            Console.ReadKey();
        }
    }


}
