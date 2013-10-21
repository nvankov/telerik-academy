using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaxSequenceOfEquals
{
    class MaxSequenceOfEquals
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int lenght = 0;
            int bestLenght = 0;
            int startingIndex = 0;
            int elementInBestSequence = array[0];

            for (int index = 0; index < array.Length - 1; index++)
            {
                if (array[index] == array[index + 1])
                {
                    lenght++;

                    if (bestLenght < lenght)
                    {
                        bestLenght = lenght;
                        startingIndex = index - bestLenght + 1;
                        elementInBestSequence = array[startingIndex];
                    }
                }
                else
                {
                    lenght = 0;
                }
            }

            Console.Write("Max sequence of equal numbers: ");

            for (int index = startingIndex; index < startingIndex + bestLenght + 1; index++)
            {
                Console.Write("{0} ", array[index]);
            }

            Console.WriteLine();
            Console.WriteLine("The sequence contains the number: {0}", elementInBestSequence);
            Console.WriteLine("Occurances: {0}", bestLenght + 1);


        }
    }
}
