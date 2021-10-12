using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while_und_while
{
    class Program
    {
        static void Main()
        {
            //gerade Zahlen
            int Zahl = 1;
            while (Zahl <= 100)
            {
                if (Zahl % 2 == 0)
                {
                    Console.WriteLine(Zahl);
                }
                Zahl += 1;
            }
            //ungerade Zahlen
            int Zahl2 = 1;
            while (Zahl2 <= 100)
            {
                if (Zahl2 % 2 != 0)
                {
                    Console.WriteLine(Zahl2);
                }
                Zahl2 += 1;
            }

            Console.ReadKey();
        }
    }
    
}
