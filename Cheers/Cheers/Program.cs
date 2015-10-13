using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the user's name and print it.
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name);

            //Cheer the user on.
            foreach (char letter in name)
            {
                string vowels = "aeiofhlmnrsx";
                string article = "a";
                if (vowels.Contains(Char.ToLower(letter)) == true)
                {
                    article = "an";
                }
                Console.WriteLine("Give me " + article + " " + letter);
            }
            Console.WriteLine(name + " is GRAND!");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
