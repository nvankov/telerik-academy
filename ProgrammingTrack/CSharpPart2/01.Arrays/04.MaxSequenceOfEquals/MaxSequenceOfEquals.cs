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
            int[] array = {2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
            int mostCommonElement = 0;
            int lenght = 1;
            int bestLenght = 0;
            int startingIndex = 1;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    lenght++;
                }
                else
                {
                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                        mostCommonElement = array[i];
                        startingIndex = i - bestLenght + 1;
                    }
                    lenght = 1;
                }

            }

            if (lenght > bestLenght)
            {
                bestLenght = lenght;
                mostCommonElement = array[array.Length - 1];
                startingIndex = array[array.Length - 1];
            }

            Console.WriteLine("Maximum sequence of equal numbers is {0} composed of the value: {1}", bestLenght, mostCommonElement);
            Console.WriteLine("The sequence is: ");
            for (int i = 0; i < bestLenght; i++)
            {
                Console.Write(array[startingIndex + i]);
                Console.Write(" ");
            }
        }
    }
}
