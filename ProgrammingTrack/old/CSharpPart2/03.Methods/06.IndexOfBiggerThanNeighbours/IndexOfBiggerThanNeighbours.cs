using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.BiggerThanTwoNeighbours;

namespace _06.IndexOfBiggerThanNeighbours
{
    class IndexOfBiggerThanNeighbours
    {
        static void Main(string[] args)
        {
            
        }

        public static int indexOfFirstBigger(int[] array, int index)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                bool isBiggerThanNeighbours = BiggerThanTwoNeighbours.CheckIfBigger(array, i);

                if (isBiggerThanNeighbours)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
