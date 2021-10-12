using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Türsteher_aufgabe_Gruppe
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Wie alt bist du");
            int Alter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hast du einen Ausweis dabei?");
            string inputAusweis = Console.ReadLine();
            bool Ausweis = bool.Parse(inputAusweis);

            {
                if (Alter >= 18 && Ausweis == true)
                {
                    Console.WriteLine("Herzlich Wilkommen");


                }

                else  
                {
                    Console.WriteLine("Wo ist dein Ausweis");
                    int Geld = Convert.ToInt32(Console.ReadLine());
                    if (Geld >= 100)
                    {
                        Console.WriteLine("Wilkommen");
                    }
                }
                if (Alter > 18 || Ausweis == false)
                {
                    Console.WriteLine("Oder hast du eine Spende ?");
                    int Geld = Convert.ToInt32(Console.ReadLine());
                    if (Geld >= 100)
                    {
                        Console.WriteLine("Wilkommen");
                    }
                    else
                    {
                        Console.WriteLine("Hau ab");
                    }

                }
            }
            Console.ReadKey();

        }
    }
}

