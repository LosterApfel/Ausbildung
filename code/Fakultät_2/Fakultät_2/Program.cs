using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultät_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fakultät von n");
            int n = int.Parse(Console.ReadLine());
            int resultzähler = 0;

            long result = 1;
            for (int i = 1; i <= n; i++) 
            {
                result *= i;
                resultzähler++;
                int[] results = new int[resultzähler];
                result = results[resultzähler];
            }
        }
    }
}
