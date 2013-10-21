using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxIncreasingSequence
{
    class MaxIncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 3, 4, 2, 2, 4 };
            int lenght = 0;
            int bestLenght = 0;
            int startingIndex = 0;

            for (int index = 0; index < array.Length - 1; index++)
            {
                if (array[index] < array[index + 1])
                {
                    lenght++;

                    if (bestLenght < lenght)
                    {
                        bestLenght = lenght;
                        startingIndex = index - bestLenght + 1;
                    }
                }
                else
                {
                    lenght = 0;
                }
            }

            Console.Write("Max increasing sequence: ");

            for (int index = startingIndex; index < startingIndex + bestLenght + 1; index++)
            {
                Console.Write("{0} ", array[index]);
            }
            Console.WriteLine();
        }
    }
}
