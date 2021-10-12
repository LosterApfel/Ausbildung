using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] PersonenTabelle = new string[5, 2];
            int Zeilenzähler = 0;
            int Spaltenzähler = 0;

            while (Zeilenzähler <= 4)
            {
                Console.Write("Bitte geben Sie ihren NAMEN ein: ");
                PersonenTabelle[Zeilenzähler, Spaltenzähler] = Console.ReadLine();  //NAME Einlesen 

                Spaltenzähler++;        //Zum Adressieren der Spalte 2

                Console.Write("Bitte geben Sie ihren ALTER ein: ");
                PersonenTabelle[Zeilenzähler, Spaltenzähler] = Console.ReadLine();  //AlTER Einlesen

                Spaltenzähler = 0;		//Wieder auf NULL für das Einlesen der nächsten Zeile
                Zeilenzähler++;
            }

            Zeilenzähler = 0;                                   //Wieder auf NULL für die Ausgabe
            Spaltenzähler = 0;                                  //Wieder auf NULL für die Ausgabe

            while (Zeilenzähler <= 4)
            {
                
                Console.Write("Name: " + PersonenTabelle[Zeilenzähler, Spaltenzähler]);
                Spaltenzähler++;
                Console.WriteLine(", Alter: " + PersonenTabelle[Zeilenzähler, Spaltenzähler]);
                Spaltenzähler = 0;
                Zeilenzähler++;
            }
            
            Console.ReadKey();
        }
    }
}