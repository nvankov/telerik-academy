using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string userInput;
            StringBuilder reversedString = new StringBuilder();

            Console.Write("Enter a string to reverse: ");
            userInput = Console.ReadLine();

            for (int index = 0; index < userInput.Length; index++)
            {
                reversedString.Append(userInput[userInput.Length - 1 - index]);
            }

            Console.WriteLine("Reversed string: {0}", reversedString.ToString());
        }
    }
}
