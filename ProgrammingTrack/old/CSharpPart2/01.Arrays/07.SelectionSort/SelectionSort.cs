using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 9, 0 ,7 , 3, 4};
            int temp;
            int minValue;

            for (int index = 0; index < array.Length - 1; index++)
            {
                minValue = index;

                for (int secondIndex = index + 1; secondIndex < array.Length; secondIndex++)
                {
                    if (array[secondIndex] < array[minValue])
                    {
                        minValue = secondIndex;
                    }
                }

                if (minValue != index)
                {
                    temp = array[index];
                    array[index] = array[minValue];
                    array[minValue] = temp;
                }
            }

            Console.WriteLine("The ordered array: ");
            foreach (var item in array)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
