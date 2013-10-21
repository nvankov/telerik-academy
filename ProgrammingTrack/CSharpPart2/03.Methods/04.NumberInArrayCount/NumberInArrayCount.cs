using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberInArrayCount
{
    public class NumberInArrayCount
    {
        public static int OccurancesInArray(IEnumerable collection, int number)
        {
            int count = 0;
            foreach (var item in collection)
            {
                if ((int)item == number)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int[] array;
            int arraySize;
            int numberToSearch;

            Console.Write("Enter the size of the array: ");
            arraySize = int.Parse(Console.ReadLine());

            array = new int[arraySize];

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("Element{0} = ", index);
                array[index] = int.Parse(Console.ReadLine());
            }

            

            Console.Write("Enter the number for which to count the number of occurances: ");
            numberToSearch = int.Parse(Console.ReadLine());

            Console.WriteLine("Times the number {0} is found: {1}", numberToSearch, OccurancesInArray(array, numberToSearch));
        }
    }
}
