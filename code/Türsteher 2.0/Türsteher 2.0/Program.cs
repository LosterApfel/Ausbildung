using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Türsteher_2._0
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("TÜRSTEHER: Bei uns kommt man erst ab 18 Jahren in den Club! Wie alt bist du ? ");
            string inputAlter = Console.ReadLine();
            int Alter = int.Parse(inputAlter);
            Console.WriteLine("TÜRSTEHER: „Und, Hast du dein Ausweis dabei?“");
            string inputAusweis = Console.ReadLine();
            bool Ausweis = bool.Parse(inputAusweis);
            Console.WriteLine("Hast du eine Maske dabei?");
            string inputMaske = Console.ReadLine();
            bool Maske = bool.Parse(inputMaske);

            if (Alter >= 18 && Ausweis && Maske == true)
            {

                Console.WriteLine("TÜRSTEHER: „Du darfst rein, dann mal viel Spaß“");
            }
            else
            {
                Console.WriteLine("TÜRSTEHER: „Du kommst hier nicht rein, Hau Ab“");
            }

            Console.WriteLine("Wie hoch ist die Spende??");
            Console.WriteLine("Wie hoch ist die Spende?");
            string input4 = Console.ReadLine();
            int summe = int.Parse(input4);
            if (summe >= 100)
                Console.ReadKey();



        }
    }
}

