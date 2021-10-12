using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99999999999999999999999999999
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Wie alt bist du ? ");
            string inputalter = Console.ReadLine();
            int alter = int.Parse(inputalter);
            if (alter >= 18)

            {

                Console.WriteLine("Cool wenn du willst können wir in Kontakt bleiben");
            }

            else
            {

                Console.WriteLine("Uff ich bin nicht Yo Oli vielleicht in paar Jahren");
            }

                Console.WriteLine("Wenn du willst kannst du mir deine Nummer geben ?");
            string intnummer = Console.ReadLine();
            bool nummer = bool.Parse(intnummer);



            if (nummer == true)
            {
                Console.WriteLine("Nice ^^");

            }

            else if (nummer == false)
            {
                Console.WriteLine("Schade!");
            }


            Console.WriteLine("Lust was zu trinken? ");
            string intsaufen = Console.ReadLine();
            bool saufen = bool.Parse(intsaufen);


            if (saufen == true)
            {
                Console.WriteLine("Geil ALLA XD !!");
                Console.ReadKey();

            }

            else if(saufen == false)
            {
                Console.WriteLine("Schade vielleicht wann anders ");

                Console.ReadKey();

            }

            
        }

    }
}







            

            










        



