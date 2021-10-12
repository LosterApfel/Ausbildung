using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakki_Zahlenraten
{
    class Program
    {
        static void Main(string[] args)
        { 

                Random rnd = new Random();



                int zz = rnd.Next(1, 101);

                int eingabe = 0;



                Console.WriteLine("Eine zufallszahl zwischen 1 und 100 wurde erzeugt. Errate!");

                do

                {

                    Console.WriteLine("Was ist die Zahl?");



                    eingabe = Convert.ToInt32(Console.ReadLine());



                    if (zz > eingabe)

                        Console.WriteLine("Die Zahl ist größer");

                    else 
                    {

                    if (zz < eingabe)

                        Console.WriteLine("Die Zahl ist kleiner");

                    else

                        Console.WriteLine("Du hast die Zahl gefunden");
            



                }



                } while (eingabe != zz);



                Console.ReadLine();

            }
        }
    }

