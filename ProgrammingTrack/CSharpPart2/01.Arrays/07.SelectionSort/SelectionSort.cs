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
            int[] array = { 0, -7, 3, 1, 2, 5};

            Console.WriteLine("Printing the array before the sorting: ");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            for (int index = 0; index < array.Length; index++)
            {
                for (int i = index + 1; i < array.Length; i++)
                {
                    if (array[index] > array[i])
                    {
                        //Swap the two numbers
                        array[index] = array[index] + array[i];
                        array[i] = array[index] - array[i];
                        array[index] = array[index] - array[i];
                    }
                }
            }

            Console.WriteLine("Printing the array after the sorting: ");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
