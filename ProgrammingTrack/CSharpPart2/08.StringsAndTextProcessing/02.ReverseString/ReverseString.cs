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
            StringBuilder reverse;

            Console.Write("Please enter a string to be reversed: ");
            userInput = Console.ReadLine();

            reverse = new StringBuilder(userInput.Length);

            for (int index = 0; index < userInput.Length; index++)
            {
                reverse.Append(userInput[userInput.Length - 1 - index]);
            }

            Console.WriteLine(reverse.ToString());

            
        }
    }
}
