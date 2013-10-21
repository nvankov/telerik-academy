using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SequenceOfMaxSum
{
    class SequenceOfMaxSum
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int bestSum = int.MinValue;
            int endingIndex = 0;
            int startingIndex = 0;
            int startTemp = 0;
            int sum = array[0];

            Console.WriteLine("Printing the array: ");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            for (int index = 1; index < array.Length; index++)
            {

                if (sum < 0)
                {
                    sum = array[index];
                    startTemp = index;
                }
                else
                {
                    sum += array[index];
                }

                if (bestSum < sum)
                {
                    bestSum = sum;
                    endingIndex = index;
                    startingIndex = startTemp;
                }


            }

            Console.WriteLine("Best sum: {0}", bestSum);
            Console.Write("Printing the best sum: ");
            for (int index = startingIndex; index <= endingIndex; index++)
            {
                Console.Write("{0} ", array[index]);
            }
            Console.WriteLine();
        }
    }
}
