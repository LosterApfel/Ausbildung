using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banknote
{
    class Program
    {
    
            static void ueberschrift()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            static void gruen()
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            static void rot()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            static void nix()
            {
                Console.ResetColor();
            }
            static string Umwandlung(string Eingabe)
            {

                Eingabe = Convert.ToString(Console.ReadLine());
                Eingabe = Eingabe.Replace("A", "1");
                Eingabe = Eingabe.Replace("B", "2");
                Eingabe = Eingabe.Replace("C", "3");
                Eingabe = Eingabe.Replace("D", "4");
                Eingabe = Eingabe.Replace("E", "5");
                Eingabe = Eingabe.Replace("F", "6");
                Eingabe = Eingabe.Replace("G", "7");
                Eingabe = Eingabe.Replace("H", "8");
                Eingabe = Eingabe.Replace("I", "9");
                Eingabe = Eingabe.Replace("J", "10");
                Eingabe = Eingabe.Replace("K", "11");
                Eingabe = Eingabe.Replace("L", "12");
                Eingabe = Eingabe.Replace("M", "13");
                Eingabe = Eingabe.Replace("N", "14");
                Eingabe = Eingabe.Replace("O", "15");
                Eingabe = Eingabe.Replace("P", "16");
                Eingabe = Eingabe.Replace("Q", "17");
                Eingabe = Eingabe.Replace("R", "18");
                Eingabe = Eingabe.Replace("S", "19");
                Eingabe = Eingabe.Replace("T", "20");
                Eingabe = Eingabe.Replace("U", "21");
                Eingabe = Eingabe.Replace("V", "22");
                Eingabe = Eingabe.Replace("W", "23");
                Eingabe = Eingabe.Replace("X", "24");
                Eingabe = Eingabe.Replace("Y", "25");
                Eingabe = Eingabe.Replace("Z", "26");
                return Eingabe;
            }

            static string Ausnahme(string Eingabe)
            {

                if (Eingabe.Length != 13)
                {
                    Console.WriteLine();
                    rot();
                    Console.WriteLine("Die Eingabe erfüllt nicht die Struktur.");
                    Console.WriteLine();
                    nix();
                }
                return Eingabe;
            }
            static void Main(string[] args)
            {
                string Entscheidung = "";
                do
                {

                    string Eingabe = "";
                    string Ausnahm = "";
                    int pruef = 0;
                    Int32 Ausgabe;
                    List<int> Ausgabee = new List<int>();


                    do
                    {
                        ueberschrift();
                        Console.Write("Geben Sie den Code auf einem Euro-Schein ein: ");
                        nix(); gruen();
                        Eingabe = Umwandlung(Eingabe);
                        nix();
                        Ausnahm = Ausnahme(Eingabe);

                    } while (Eingabe.Length != 13);


                    //definiert die Prüfvariable
                    for (int i = Eingabe.Length - 1; i < Eingabe.Length; i++)
                    {
                        string ein = Eingabe.Substring(i, 1);
                        Int32.TryParse(ein, out Ausgabe);
                        pruef = Ausgabe;
                    }
                    //wandelt die Ziffern einzeln um, damit man daraus eine Quersumme bilden kann
                    for (int i = 0; i < Eingabe.Length - 1; i++)
                    {
                        string ein = Eingabe.Substring(i, 1);
                        Int32.TryParse(ein, out Ausgabe);
                        Ausgabee.Add(Ausgabe);
                    }


                    //Berechnung. Rundet das Ergebnis auf.
                    Console.WriteLine();
                    rot();
                    double rest = 0;
                    rest = (double)Ausgabee.Sum() / 9;
                    rest = Math.Ceiling(rest);
                    rest = 8 - rest;
                    //Ausgabe des Ergebnis
                    if (rest == 0)
                    {
                        Console.WriteLine("DIe Prüfziffer beträgt 9.");
                        if (pruef == 9)
                        {
                            Console.WriteLine("Die Banknote ist echt.");
                        }
                        if (pruef != 9)
                        {
                            Console.WriteLine("Die Banknote ist eine Fälschung.");
                        }
                    }
                    if (rest != 0)
                    {

                        Console.WriteLine("Die Prüfziffer beträgt: " + rest);

                        if (rest == pruef)
                        {
                            Console.WriteLine("Die Banknote ist echt.");
                        }
                        if (rest != pruef)
                        {
                            Console.WriteLine("Die Banknote ist eine Fälschung.");
                        }
                    }
                    nix();
                    Console.WriteLine();
                    Console.Write("Möchten Sie noch eine Banknote prüfen ? ");
                    Entscheidung = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();
                } while (Entscheidung == "ja" || Entscheidung == "j");

            }
        
    }
}
