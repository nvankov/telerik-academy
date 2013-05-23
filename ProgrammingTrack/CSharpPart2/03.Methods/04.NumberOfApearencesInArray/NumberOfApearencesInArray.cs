using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberOfApearencesInArray
{
    class NumberOfApearencesInArray
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 6, 7, 3, 34, 8, 9, 34, 2, 2, 1, 0, 54, 6 };
            int numberToCheck = 2;

            Console.WriteLine("Times the number {0} is found in the array: {1} times.", 
                numberToCheck, NumberOfOccurences(array, numberToCheck));
        }

        public static int NumberOfOccurences(int[] userArray, int number)
        { 
            int occurences = 0;

            foreach (var item in userArray)
            {
                if (number == item)
                {
                    occurences++;
                }
            }

            return occurences;

        }
    }
}
