using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Arrey
{
    class Program
    {
        static void Main()
        {
            string[,] NameAlter = new string[5, 5];
            NameAlter[0, 0] = "Dennis DerallerEchte";
            NameAlter[0, 1] = "19 Jahre";

            NameAlter[1, 0] = "Erich Mit CH";
            NameAlter[1, 1] = "21 Jahre";

            NameAlter[2, 0] = "Heiko mim Dönerladen";
            NameAlter[2, 1] = "17 Jahre";

            NameAlter[3, 0] = "Boris der Hakka";
            NameAlter[3, 1] = "12 Jahre";

            NameAlter[4, 0] = "Lenerd";
            NameAlter[4, 1] = "18 Jahre";

            Console.WriteLine(NameAlter[0, 0] + " ist " + NameAlter[0, 1] + "\n" + NameAlter[1, 0] + " ist " + NameAlter[1, 1] + "\n" + NameAlter[2, 0] + " ist " + NameAlter[2, 1] + "\n" + NameAlter[3, 0] + " ist " + NameAlter[3, 1] + "\n" + NameAlter[4, 0] + " ist " + NameAlter[4, 1]);
            Console.ReadKey();
        }


    }
}
