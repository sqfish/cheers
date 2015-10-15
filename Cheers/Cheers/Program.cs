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
            string name = NameCheer();
            BirthdayCheer(name);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static string NameCheer()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name);
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
            return name;
        }

        private static void BirthdayCheer(string name)
        {
            Console.WriteLine("When is your birthday? Please use MM/DD format.");
            string input = Console.ReadLine();
            try
            {
                DateTime birthday = DateTime.ParseExact(input, "MM/dd", null);
                TimeSpan diff = birthday.Subtract(DateTime.Today);
                if (diff.Days > 0)
                {
                    Console.WriteLine("Your birthday is in {0} day(s)!", diff.Days);
                }
                else if (diff.Days < 0)
                {

                    Console.WriteLine("Your birthday is in {0} day(s)!", diff.Days + 365 + 1);
                }
                else
                {
                    Console.WriteLine("Happy Birthday, {0}!!!", name);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You entered an invalid birthday.");
            }
        }
    }
}
