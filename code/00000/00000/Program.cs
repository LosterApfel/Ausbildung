using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00000
{
    class Program
    {
        static void Main(string[] args)
        {
            int Summe = 0;
            int X = 5;
            while (X > 1)
            {
                Summe = Summe + X;
                if (Summe > 10)
                {
                    X = 1;
                }
                else
                {
                    X = X - 1;
                }
                
            }
            Console.WriteLine(Summe);
            Console.ReadKey();
        }
    }
}
        
    

