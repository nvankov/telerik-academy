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

            Console.Write("Please enter the number of elements in the array: ");
            userInput = Int32.Parse(Console.ReadLine());

            firstArray = new int[userInput];
            secondArray = new int[userInput];

            Console.WriteLine("Entering the numbers for the arrays:");
            Console.WriteLine();

            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write("Element number {0} for the first array: ", index);
                firstArray[index] = Int32.Parse(Console.ReadLine());

                Console.Write("Element number {0} for the second array: ", index);
                secondArray[index] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Comparing elements of the two arrays: ");
            Console.WriteLine();

            for (int index = 0; index < userInput; index++)
            {
                Console.Write("Comparing at position {0}: ", index);

                if (firstArray[index] == secondArray[index])
                {
                    Console.WriteLine("The elements are equal ({0} = {1}).", firstArray[index], secondArray[index]);
                }
                else
                {
                    if (firstArray[index] > secondArray[index])
                    {
                        Console.WriteLine("The first element is greater than the second ({0} > {1}).", 
                            firstArray[index], secondArray[index]);
                    }
                    else
                    {
                        Console.WriteLine("The first element is smaller than the second ({0} < {1}).",
                            firstArray[index], secondArray[index]);
                    }
                }
            }
        }
    }
}
