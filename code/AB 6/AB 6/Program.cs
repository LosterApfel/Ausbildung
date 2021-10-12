using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 2;
            int c = a * b / b++;
            a++;
            int d = ++a / b;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadKey();
        }
        
    }
    
}
