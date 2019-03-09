using System;
using System.Collections.Generic;

namespace CodeChallenges
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            var userInput = Console.ReadLine().ToLower();
            //var inputString = new List<char>();
            var inputString = "";
            var compareString = "";

            // Removes punctuation
            foreach (char myChar in userInput)
            {
                if (!char.IsPunctuation(myChar))
                {
                    inputString += myChar;
                }
            }

            // Removes spaces
            inputString = inputString.Replace(" ", string.Empty);

            // Reverses the string using the ReverseString method
            compareString = ReverseString(inputString);

            // Compares the two strings
            if(compareString == inputString)
            {
                Console.WriteLine("True! You have a palindrome");
            }
            else
            {
                Console.WriteLine("False! You don't have a palindrome");
            }

            Console.ReadLine();
        }

        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}

