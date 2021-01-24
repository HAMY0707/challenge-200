using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bluefragments
{
    class Cryptography
    {
        //Create two functions that take a string and an array and returns a coded or decoded message.

        //The first letter of the string, or the first element of the array represents the Character Code of that letter.The next elements are the differences between the characters: e.g.A + 3-- > C or z -1-- > y.

        //Examples:
        //Encrypt("Hello") ➞ [72, 29, 7, 0, 3]
        //// H = 72, the difference between the H and e is 29 (upper- and lowercase).
        //// The difference between the two l's is obviously 0.
        //Decrypt([72, 33, -73, 84, -12, -3, 13, -13, -68]) ➞ "Hi there!"
        //Encrypt("Sunshine") ➞ [83, 34, -7, 5, -11, 1, 5, -9]

        private string[] _encodedArray { get; set; }
        private char[] _decodedArray { get; set; }

        public void Run()
        {
            var programSelected = this.SelectProgramToRun();
            if (programSelected == null) this.Run();

            

            if(programSelected == 1)
            {
                Console.WriteLine("Type in message to encrypt");
                var input = Console.ReadLine();
                var result = this.Encode(input);

                this.ShowResult(result);
            }
            else if(programSelected == 2)
            {
                Console.WriteLine("Type in message to decrypt");
                var input = Console.ReadLine();
                var result = this.Decode(input);

                this.ShowResult(result);
            }
            else
            {
                Console.WriteLine("Invalid input");
                this.Run();
            }
        }

        private void ShowResult (string result)
        {
            Console.WriteLine("The result is");
            Console.WriteLine(result);
        }

        private int? SelectProgramToRun()
        {
            try
            {
                Console.WriteLine("Do you want to Encrypt or Decrypt a message?");
                Console.WriteLine("Press 1. to encrypt message");
                Console.WriteLine("Press 2. to decrypt message");

                return int.Parse(Console.ReadLine());
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Invalid input");
                return null; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Encode(string input)
        {
            this._decodedArray = input.ToCharArray();
            this._encodedArray = new string[_decodedArray.Length];

            for (int i = 0; i < _decodedArray.Length; i++)
            {
                var currentCharacterCode = GetCodeFromCharacter(i);
                var previousCharacterCode = this.GetPreviousCharacterCode(i);

                var encoded =  currentCharacterCode - previousCharacterCode;
                _encodedArray[i] = encoded.ToString();
            }

            return JoinArrayToString(_encodedArray);
        }

        public string Decode(string encrypted)
        {
            _encodedArray = this.SplitString(encrypted);
            _decodedArray = new char[_encodedArray.Length];

            this._encodedArray = _encodedArray;

            int previousEncoded = 0;
            
            for (int i = 0; i < _encodedArray.Length; i++)
            {
                try
                {
                    int encoded = int.Parse(_encodedArray[i]);
                    
                    if (i != 0)
                    {
                        encoded += previousEncoded; 
                    }

                    char decoded = this.GetCharacterFromCode(encoded);
                    _decodedArray[i] = decoded;

                    previousEncoded = encoded;
                }
                catch (Exception ex)
                { 
                    throw ex;
                }
            }

            return new string(_decodedArray);
        }

        private int GetPreviousCharacterCode(int loopIndex)
        {
            var previousCharacterCode = 0;

            if (loopIndex > 0)
            {
                previousCharacterCode = GetCodeFromCharacter(loopIndex - 1);
            }
            return previousCharacterCode;
        }

        private string[] SplitString(string stringToSplit)
        {
            return stringToSplit.Split(",");
        }

        private string JoinArrayToString (string[] array)
        {
            return string.Join(",", array);
        }

        private char GetCharacterFromCode(int encoded)
        {
            var character = (char)encoded;
            return character;
        }

        private int GetCodeFromCharacter(int i)
        {
            var character = _decodedArray[i];
            return (int)character;
        }

        private Char FindPreviousChar(int i)
        {
            return _decodedArray[i - 1];
        }
    }
}
