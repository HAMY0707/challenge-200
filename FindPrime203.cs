using System;
using System.Collections.Generic;
using System.Text;

namespace Bluefragments
{
    class FindPrime203
    {
        //Create a function that finds a target number in a list of prime numbers.Implement a binary search algorithm in your function. The target number will be from 2 through 97.If the target is prime then return "yes" else return "no".

        //Examples: int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }
        //IsPrime(primes, 3) ➞ "yes"
        //IsPrime(primes, 4) ➞ "no"
        //IsPrime(primes, 67) ➞ "yes"
        //IsPrime(primes, 36) ➞ "no"
        private readonly int[] _listOfPrimes;
        public FindPrime203()
        {
            this._listOfPrimes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        }
        public void Run()
        {
            try
            {
                Console.WriteLine("I will return true if your integer is in the list of primes.");
                var input = int.Parse(Console.ReadLine());

                var result = this.IsPrimeFound(input);

                Console.WriteLine("The result is:");
                Console.WriteLine(result);

                Console.WriteLine("");
                Console.WriteLine("Note: As I was creating this, I found Array.BinarySearch() in intellisense by mistake/fortune. I thought this showed more of my process than just writing Array.BinarySearch(_inputNumber). But it's definetly cleaner :-)");

                Console.ReadLine();
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Invalid input");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool IsPrimeFound(int number)
        {
            var lastIndex = _listOfPrimes.Length - 1;
            var firstIndex = 0;



            var begin = _listOfPrimes[0];
            var end = _listOfPrimes[lastIndex];
            bool isFound = false;

            while (lastIndex != firstIndex && !isFound)
            {
                var middleIndex = (lastIndex + firstIndex) / 2;
                var middle = _listOfPrimes[middleIndex];


                if (middle == number) isFound = true;

                if (this.IsInLowerHalf(number, middle))
                {
                    if (end == middle) break;

                    end = middle;
                    lastIndex = middleIndex;
                }
                else
                {
                    if (begin == middle) break;

                    begin = middle;
                    firstIndex = middleIndex;
                }
            }

            return isFound;
        }

        private bool IsInLowerHalf(int number, int middle)
        {
            return number < middle;
        }
    }
}
