using _05.CheckForBiggerNeighbours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IndexOfFirstBiggerElement
{
    class Program
    {
        static int IndexOfFirstBigger(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (CheckForBiggerNeighbours.CheckNeigbours(array, index))
                {
                    return index;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 6, 7};
            Console.WriteLine("Printing the array: ");

            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            if (IndexOfFirstBigger(array) == -1)
            {
                Console.WriteLine("There isn't an element that is bigger than its neigbours.");
            }
            else
            {
                Console.WriteLine("The first element that is bigger than its neigbours is at position: {0}", 
                    IndexOfFirstBigger(array));
            }
        }
    }
}
