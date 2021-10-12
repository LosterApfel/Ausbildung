using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("alle/ungerade/gerade");
            String Zahlen = Console.ReadLine();
            int zahl = 1;



            switch (Zahlen)
            {
                case "alle":
                    while (zahl <= 100)
                    {
                        Console.WriteLine(zahl);
                        zahl++;
                    }
                    break;



                case "ungerade":
                    while (zahl <= 100)
                    {
                        Console.WriteLine(zahl);
                        zahl += 2;
                    }
                    break;



                case "gerade":
                    zahl++;
                    while (zahl <= 100)
                    {
                        Console.WriteLine(zahl);
                        zahl += 2;
                    }
                    break;
            }

        }
    }

}