using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int number = 4;
            int lenght = array.Length / 2;
            

            Array.Sort(array);

            Console.WriteLine("Printing sorted array: ");
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            for (int index = 0; index < array.Length / 2; index++)
            {
                if (number == array[lenght])
                {
                    break;
                }
                else
                {
                    if (number < array[lenght])
                    {
                        lenght /= 2;
                    }
                    if (number > array[lenght])
                    {
                        lenght += lenght / 2;
                        if (lenght > array.Length - 1)
                        {
                            break;
                        }
                    }
                }
                
            }

            Console.WriteLine("The number {0} is at position {1}", number, lenght);


        }
    }
}
