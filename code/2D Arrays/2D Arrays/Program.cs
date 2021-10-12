using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            string[,] PersonenTabelle = new string[5, 2];
            int Zeilenzähler = 0;
            int Spaltenzähler = 0;





            while (Zeilenzähler <= 4)
            {
                Console.Write("Bitte geben Sie ihren NAMEN ein: ");
                PersonenTabelle[Zeilenzähler, Spaltenzähler] = Console.ReadLine();
                Spaltenzähler++;
                Console.Write("Bitte geben Sie ihr ALTER ein: ");
                PersonenTabelle[Zeilenzähler, Spaltenzähler] = Console.ReadLine();
                Spaltenzähler = 0;
                Zeilenzähler++;
            }

            Zeilenzähler = 0;
            Spaltenzähler = 0;







            Console.WriteLine("\nDie volljährigen Personen sind \n");

            int Alter;
            while (Zeilenzähler <= 4)
            {
                Alter = int.Parse(PersonenTabelle[Zeilenzähler, 1]);
                if (Alter >= 18)
                {
                    Console.WriteLine(PersonenTabelle[Zeilenzähler, 0]);
                }
                Zeilenzähler++;
            }
            Zeilenzähler = 0;
            Console.ReadKey();

            Console.WriteLine("\nDiese Personen sind unter 18 Jahre alt");
            while (Zeilenzähler <= 4)
            {
                Alter = int.Parse(PersonenTabelle[Zeilenzähler, 1]);
                if (Alter < 18)
                {
                    Console.WriteLine(PersonenTabelle[Zeilenzähler, 0]);
                }
                Zeilenzähler++;
            }
            Console.ReadKey();
        }
    }
}