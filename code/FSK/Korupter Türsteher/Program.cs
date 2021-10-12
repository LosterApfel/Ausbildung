using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korupter_Türsteher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie alt sind sie?");
            string input = Console.ReadLine();
            int Alter = int.Parse(input);
            Console.WriteLine("Sind sie PRIME-Kunde bei uns?");
            string inputPrime = Console.ReadLine();
            bool PremiumMembership = bool.Parse(inputPrime);
            //bool PremiumMembership = inputPrime;
            if (Alter >= 18 && PremiumMembership == true)
            {

                Console.WriteLine("Sie dürfen bei uns Filme Streamen, Willkommen und viel Spaß!");
            }
            else
            {
                Console.WriteLine("Sie dürfen keine Filme bei uns Streamen !");
            }
            Console.ReadKey();


        }
    }
}
