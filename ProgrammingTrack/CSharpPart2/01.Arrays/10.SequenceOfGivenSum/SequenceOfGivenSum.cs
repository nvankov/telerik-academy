using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SequenceOfGivenSum
{
    class SequenceOfGivenSum
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int S = 11;
            int startIndex = 0;
            int endIndex = 0;
            int sum = array[0];

            Console.WriteLine("Printing the array: ");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("Searching for the sum of {0}: ", S);

            for (int index = 0; index < array.Length - 1; index++)
            {
                sum = array[index];

                for (int secondIndex = index + 1; secondIndex < array.Length; secondIndex++)
                {
                    if (sum < S)
                    {
                        sum += array[secondIndex];
                    }
                    else
                    {
                        if (sum == S)
                        {
                            startIndex = index;
                            endIndex = secondIndex;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (sum == S)
                {
                    break;
                }

            }

            if (sum == S)
            {
                Console.Write("There is a sequence of the given sum: ");
                for (int index = startIndex; index < endIndex; index++)
                {
                    Console.Write("{0} ", array[index]);
                }
                Console.WriteLine();
            }
        }
    }
}
