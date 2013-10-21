using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareTwoArrays
{
    class CompareTwoArrays
    {
        static void Main(string[] args)
        {
            int userInput;
            int[] firstArray;
            int[] secondArray;
            bool areEqual = true;

            Console.Write("Enter how much element will the two arrays have: ");
            userInput = int.Parse(Console.ReadLine());

            firstArray = new int[userInput];
            secondArray = new int[userInput];

            Console.WriteLine("Entering elements for the first array: ");
            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write("Element[{0}] = ", index+1);
                firstArray[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entering elements for the second array: ");
            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write("Element[{0}] = ", index+1);
                secondArray[index] = int.Parse(Console.ReadLine());
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
