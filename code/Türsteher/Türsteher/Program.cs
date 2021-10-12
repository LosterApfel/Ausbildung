using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Türsteher
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
            if (Alter >= 18 && Ausweis == true)
            {

                Console.WriteLine("TÜRSTEHER: „Du darfst rein, dann mal viel Spaß“");
            }
            else
            {
                Console.WriteLine("TÜRSTEHER: „Du kommst hier nicht rein, Hau Ab“");
            }
            Console.ReadKey();

        }
    }
}