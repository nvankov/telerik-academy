using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            int userInput;
            char[] firstArray;
            char[] secondArray;
            bool areEqual = true;

            Console.Write("Enter how much element will the two arrays have: ");
            userInput = int.Parse(Console.ReadLine());

            firstArray = new char[userInput];
            secondArray = new char[userInput];

            Console.WriteLine("Entering elements for the first array: ");
            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write("Element[{0}] = ", index + 1);
                firstArray[index] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entering elements for the second array: ");
            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write("Element[{0}] = ", index + 1);
                secondArray[index] = char.Parse(Console.ReadLine());
            }

            for (int index = 0; index < userInput; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    areEqual = false;
                }
            }

            Console.WriteLine("Are the two arrays equal: {0}", areEqual); //или areEqual ? "Yes" : "No"
        }
    }
}
