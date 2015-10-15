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
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name);
            Console.WriteLine("When is your birthday? Please use MM/DD format.");
            string input = Console.ReadLine();
            DateTime birthday = DateTime.ParseExact(input, "MM/dd", null);
            foreach (char letter in name.ToLower())
            {
                if (Char.IsLetter(letter))
                {
                    string vowels = "aeiofhlmnrsx";
                    string article = "a";
                    if (vowels.Contains(letter) == true)
                    {
                        article = "an";
                    }
                    Console.WriteLine("Give me " + article + "..." + letter);
                }
            }
            Console.WriteLine(name.ToUpper() + " is... GRAND!");
            TimeSpan diff = birthday.Subtract(DateTime.Today);
            if (diff.Days > 0)
            {
                Console.WriteLine("Your birthday is {0} days away!", diff.Days);
            }
            else if (diff.Days < 0)
            {
                Console.WriteLine("Your birthday is {0} days away!", diff.Days + 365 + 1);
            }
            else
            {
                Console.WriteLine("Happy Birthday, {0}!!!", name);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
