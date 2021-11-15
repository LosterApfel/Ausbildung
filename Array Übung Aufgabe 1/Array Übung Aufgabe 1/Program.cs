using System;
using System.Collections;

namespace Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Namensliste = new ArrayList();

            Namensliste.Add("Michi");
            Namensliste.Add("Sissi");
            Namensliste.Add("Denis");
            Namensliste.Add("Franz");
            Namensliste.Add("Nummer5");
            
            Console.WriteLine("Nach wem suchst du?");

            string eingabe = Console.ReadLine();
            if (Namensliste.Contains(eingabe))
            {
                Console.WriteLine(eingabe + " ist der Schulklasse vorhanden");
            }
            else
            {
                Console.WriteLine(eingabe + " ist nicht vorhanden");
            }
            Console.ReadKey();
        }
    }
}