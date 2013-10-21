using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BinarySearchInArray
{
    class BinarySearchInArray
    {
        static void Main(string[] args)
        {
            int[] userInput;
            int n;
            int k;

            Console.Write("Enter the number of element in the array: ");
            n = int.Parse(Console.ReadLine());

            userInput = new int[n];

            for (int index = 0; index < userInput.Length; index++)
            {
                userInput[index] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter a value to be searched in the array: ");
            k = int.Parse(Console.ReadLine());

            Array.Sort(userInput);

            int binaryResult = Array.BinarySearch(userInput, k);

            //Ако е отрицателно число не е намерен елемента, а ако побитово се 
            //инвентира стойността ще се намери индекса на следващият елемент

            if (binaryResult < 0)
            {
                Console.WriteLine("The element {0} was not found. The next larger element in the array is: {1}", k, userInput[~binaryResult]);
            }
            else
            {
                Console.WriteLine("The element {0} is found! You can find it at index: {1}", k, binaryResult);
            }
        }
    }
}
