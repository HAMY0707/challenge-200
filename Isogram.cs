using System;
using System.Collections.Generic;
using System.Text;

namespace Bluefragments
{
    class Isogram
    {
        public void Run()
        {
            Console.WriteLine("Type in something and I will tell you whether its an isogram");
            var input = Console.ReadLine();

            var result = this.IsIsogram(input);

            Console.WriteLine("The result is:");
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        public bool IsIsogram (string input)
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
