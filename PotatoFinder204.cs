using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Bluefragments
{
    class PotatoFinder204
    {
        // challenge-204
        // Create a function to return the amount of potatoes there are in a string.
        //Examples:
        //Potatoes("potato") ➞ 1
        //Potatoes("potatopotato") ➞ 2
        //Potatoes("potatoapple") ➞ 1
        public void RunPotatoFinder()
        {
            Console.WriteLine("I will find potatoes in your input!");
            var inputString = Console.ReadLine();

            int count = this.CountPotatoesInString(inputString);

            Console.WriteLine($"The number of potatoes found was {count}");
            Console.ReadLine();
        }

        private int CountPotatoesInString(string inputString)
        {
            return Regex.Matches(inputString.ToLower(), "potato").Count;
        }
    }
}
