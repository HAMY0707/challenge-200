using System;
using System.Collections.Generic;
using System.Text;

namespace Bluefragments
{
    class Maskify201
    {
        //Examples:
        //Maskify("4556364607935616") ➞ "############5616"
        //Maskify("64607935616") ➞ "#######5616"
        //Maskify("1") ➞ "1"
        //Maskify("") ➞ ""

        private readonly int _lengthToShow = 4;
        public void Run()
        {
            Console.WriteLine("Type in something secret and I will mask it for you!");
            var input = Console.ReadLine();

            var result = this.MaskString(input);

            Console.WriteLine("The result is:");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private string MaskString(string stringToMask)
        {
            if (stringToMask.Length <= 4) return stringToMask;

            var maskedString = Mask(stringToMask);
            return maskedString;
        }

        private string Mask(string stringToMask)
        {
            int countOfMask = stringToMask.Length - _lengthToShow;
            var maskedPart = new string('#', countOfMask);

            var shownPart = stringToMask.Substring(stringToMask.Length - _lengthToShow, _lengthToShow);
            return maskedPart + shownPart;
        }
    }
}
