using System;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

namespace PalindromeCheck
{
    class Program
    {
        public static void Main(string[] args = null)
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = loggerFactory.CreateLogger<Program>();

            Console.WriteLine("Please enter your name");
            string name;
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!"); //string interpolation

            for (int j = 0; j < 5; j++) // Check five strings
            {
                if (j < 5)
                {
                    Console.WriteLine(" Please enter a string");
                }

                string s, revs = "";
                s = Console.ReadLine().ToLower();
                string r = Regex.Replace(s, @"(\s|-)", ""); //Remove whitespaces

                for (int i = r.Length - 1; i >= 0; i--) //Reverse the string
                {
                    revs += r[i].ToString();
                }
                if (revs == r) // Check whether the string is a palindrome or not
                {
                    Console.WriteLine("This string is a palindrome");
                }
                else
                {
                    Console.WriteLine("This string is not a palindrome");
                }
            }

            logger.LogInformation("Hello, Intergalactic Warriors! Beware of the Dark Side of the Force!");
            logger.LogWarning("According to Master Yoda, 'Fear is the path to the Dark Side. Fear leads to anger, anger leads to hate, hate leads to suffering.'");
        }
    }
}
