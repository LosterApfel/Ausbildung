using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultät
{
    class Program
    {
        static void Main()
        {
            {


                Console.Write("Fakultät von n: ");
                int n = int.Parse(Console.ReadLine());


                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }


                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    }
}
   