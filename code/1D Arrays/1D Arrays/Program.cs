using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_Arrays
{
    class Program
    {
        static void Main()
        {
            string[] SchülerSAE = new string[10];

            SchülerSAE[0] = "Sandra";
            SchülerSAE[1] = "Xsven";
            SchülerSAE[2] = "Erich";
            SchülerSAE[3] = "Leomie";
            SchülerSAE[4] = "Dehnis";
            SchülerSAE[5] = "Heiko";
            SchülerSAE[6] = "Boriss";
            SchülerSAE[7] = "Tim";
            SchülerSAE[8] = "Emma";
            SchülerSAE[9] = "Johanna";
           



            for(int i = 0;i <= 9; i++)
            {
                Console.WriteLine(SchülerSAE[i]);
            }
            Console.ReadKey();
        }


        

    }

}
