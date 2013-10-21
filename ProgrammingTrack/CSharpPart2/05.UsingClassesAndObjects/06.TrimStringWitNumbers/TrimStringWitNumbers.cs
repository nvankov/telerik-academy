using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TrimStringWitNumbers
{
    class TrimStringWitNumbers
    {
        static void Main(string[] args)
        {
            string str = "43 68 9 23 318";
            string[] stringNumbers;
            int[] numbers;

            str.Trim();
            stringNumbers = str.Split();
            numbers = new int[stringNumbers.Length];

            for (int index = 0; index < stringNumbers.Length; index++)
            {
                numbers[index] = int.Parse(stringNumbers[index]);
            }

            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
