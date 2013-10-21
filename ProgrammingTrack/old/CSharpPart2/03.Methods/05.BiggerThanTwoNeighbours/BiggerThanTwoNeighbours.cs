using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggerThanTwoNeighbours
{
    public class BiggerThanTwoNeighbours
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 6, 7, 3, 34, 8, 9, 34, 2, 2, 1, 0, 54, 6 };
            int index = 3;

            Console.WriteLine(CheckIfBigger(array, index)); 
        }

        public static bool CheckIfBigger(int[] array, int index)
        {

            if (index <= 0 || index > array.Length - 2)
            {
                return false;
            }

            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
