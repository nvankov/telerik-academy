using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSumOfKElements
{
    class MaxSumOfKElements
    {
        static void Main(string[] args)
        {
            int n;
            int k;
            int[] array;
            int maxSum = 0;
            int startingIndex = 0;

            Console.Write("Enter the lenght of the array (n = ): ");
            n = Int32.Parse(Console.ReadLine());
            array = new int[n];

            Console.WriteLine("Enter values for the elements: ");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("Value for element [{0}]: ", index);
                array[index] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter value for k (number of element that have the max sum): ");
            k = Int32.Parse(Console.ReadLine());

            for (int index = 0; index < array.Length - k + 1; index++)
            {
                int sum = 0;

                for (int i = 0; i < k; i++)
                {
                    sum += array[index + i];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startingIndex = index;
                    }
                }

            }

            Console.WriteLine("The max sum is: {0}", maxSum);
            Console.WriteLine("Starting index: {0}", startingIndex);
            for (int index = 0; index < k; index++)
            {
                Console.WriteLine(array[index + startingIndex]);
            }
        }
    }
}
