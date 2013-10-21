using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] array = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 
                               'h', 'i', 'j', 'k', 'k', 'm', 'n', 
                               'o', 'p', 'q', 'r', 's', 'y', 'u', 
                               'v', 'w', 'c', 'y', 'z'};
            string userInput;

            Console.Write("Enter a word: ");
            userInput = Console.ReadLine();

            for (int index = 0; index < userInput.Length; index++)
            {
                for (int charIndex = 0; charIndex < array.Length; charIndex++)
                {
                    if (userInput[index] == array[charIndex])
                    {
                        Console.WriteLine("Letter {0} found on {1} position.", userInput[index], charIndex);
                    }
                }
            }
        }
    }
}
