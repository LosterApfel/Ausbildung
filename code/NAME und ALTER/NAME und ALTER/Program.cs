using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAME_und_ALTER
{
    class Program
    {
        static void Main()
        {
            

            string[,] Person = new string[5,5];
            int index = 0;
           
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("Gib dein Name ein");
                    string Name = Console.ReadLine();

                    string name = Person[0, index];
                    index++;

                {
                    Console.WriteLine(Person[0, index]);
                    string Name = (Person[0, index]);

                }
                

               




                Console.ReadKey();
            
        }
    }
}
