using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Wie alt bist du?");
                int Alter = int.Parse(Console.ReadLine());


            if (Alter >= 18)
            {
                Console.WriteLine("Herrzlich Willkommen, hast du Premium ?");
                bool Premium = bool.Parse(Console.ReadLine());
                if (Premium == true)
                {
                    Console.WriteLine("Du kannst alles sehen");
                }
            }

            else
            {
                Console.WriteLine("Du kannst nur Dokus sehen :) ");
            }

            
            
            Console.ReadKey();
        }
    }
}
    

