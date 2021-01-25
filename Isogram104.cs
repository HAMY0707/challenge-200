using System;
using System.Collections.Generic;
using System.Text;

namespace Bluefragments
{
    class Isogram104
    {
        //An isogram is a word that has no duplicate letters.Create a function that takes a string and returns either true or false depending on whether or not it's an "isogram".

        //Examples:
        //IsIsogram("Algorism") ➞ true
        //IsIsogram("PasSword") ➞ false
        //// Not case sensitive.
        //IsIsogram("Consecutive") ➞ false
        public void Run()
        {
            Console.WriteLine("Type in something and I will tell you whether its an isogram");
            var input = Console.ReadLine();

            var result = this.IsIsogram(input);

            Console.WriteLine("The result is:");
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        public bool IsIsogram(string input)
        {
            bool isIsogram = true;
            var listOfUsedChars = new List<char>();
            foreach (var character in input)
            {
                if (!listOfUsedChars.Contains(character))
                {
                    listOfUsedChars.Add(character);
                }
                else
                {
                    isIsogram = false;
                    break;
                }
            }

            return isIsogram;
        }
    }
}
