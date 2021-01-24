using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Bluefragments
{
    class Program
    {
        private static bool _isRunning = true;
        static void Main(string[] args)
        {
            while (_isRunning)
            {
                int programToRun;
                
                Console.WriteLine("Please select program to run");
                Console.WriteLine("Press 1. to find potatoes");
                Console.WriteLine("Press 2. to encrypt and decrypt a message");
                Console.WriteLine("Press 3. to find an isogram");
                Console.WriteLine("Press 4. to mask the string");
                Console.WriteLine("Press 5. to find primes in an array of primes");
                Console.WriteLine("... 0 to quit");


                try
                {
                    programToRun = int.Parse(Console.ReadLine());

                    if (programToRun == 1)
                    {
                        var potatoFinder = new PotatoFinder();
                        potatoFinder.RunPotatoFinder();
                    }
                    else if (programToRun == 2)
                    {
                        var cryptography = new Cryptography();
                        cryptography.Run();
                    }
                    else if (programToRun == 3)
                    {
                        var isogram = new Isogram();
                        isogram.Run();
                    }
                    else if (programToRun == 4)
                    {
                        var maskify = new Maskify();
                        maskify.Run();
                    }
                    else if (programToRun == 5)
                    {
                        var findPrime = new FindPrime();
                        findPrime.Run();
                    }
                    else if(programToRun == 0)
                    {
                        ExitProgram();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private static void ExitProgram ()
        {
            Console.WriteLine("The program will now exit");
            _isRunning = false;
        }
    }
}
