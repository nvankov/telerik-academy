using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaxSumSequence
{
    class MaxSumSequence
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
            int startPosition = 0;
            int endPosition = array.Length - 1;
            int biggestSum = int.MinValue;
            int arraySum = 0;
            int newSum = 0;

            for (int index = 0; index < array.Length; index++)
            {
                arraySum += array[index];
            }

            for (int index = 0; index < array.Length - 1; index++)
            {
                newSum = array[index];
                for (int secondIndex = index + 1, numbers = 1; secondIndex < array.Length; secondIndex++, numbers++)
                {
                    newSum += array[secondIndex];
                    if ((newSum > biggestSum) && (newSum > newSum + array[secondIndex + 1]))
                    {
                        endPosition = secondIndex;
                        startPosition = secondIndex - numbers;
                        break;
                    }
                }

                if (newSum > biggestSum)
                {
                    biggestSum = newSum;
                }
            }

            for (int index = startPosition; index <= endPosition; index++)
            {
                Console.Write(array[index]);
                Console.Write(" ");
            }
            Console.WriteLine();

        }
    }
}
