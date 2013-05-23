using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayOf20Ints
{
    class ArrayOf20Ints
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = index * 5;
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
