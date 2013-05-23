using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SequenceOfGivenSum
{
    class SequenceOfGivenSum
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {4, 3, 1, 4, 2, 5, 8 };
            int S = 11;
            int sum = 0;
            int start = 0;
            int end = 0;

            for (int index = 0; index < array.Length - 1; index++)
            {
                sum = array[index];
                for (int i = index + 1; i < array.Length; i++)
                {
                    sum += array[i];
                    if (sum == S)
                    {
                        start = index;
                        end = i;
                        break;
                    }
                }
                if (sum == S)
                {
                    for (int i = start; i <= end; i++)
                    {
                        Console.Write(array[i]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
