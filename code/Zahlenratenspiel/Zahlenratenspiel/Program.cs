using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenratenspiel
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            Console.WriteLine("Wählen sie zwei Zahlen aus");
            int Beginn = int.Parse(Console.ReadLine());
            int Ende = int.Parse(Console.ReadLine());
            int Zufallszahl = rnd.Next(Beginn, Ende);
            Console.WriteLine("Errate die Zahl");
            while (true)

            {
                
               
                int eingabe = int.Parse(Console.ReadLine());
                if (eingabe > Zufallszahl)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner");
                }
                else if (eingabe < Zufallszahl)
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer");
                }
                else
                {
                    Console.WriteLine("Die gesuche Zahl war " + Zufallszahl);
                    break;
                }
            }


            Console.ReadKey();

        }
    }
}
        



