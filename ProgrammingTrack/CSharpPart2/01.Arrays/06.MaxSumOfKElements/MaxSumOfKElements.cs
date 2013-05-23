using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSumOfKElements
{
    class MaxSumOfKElements
    {
        static void Main(string[] args)
        {
            int N;
            int K;
            int[] array;

            Console.Write("Enter a value for N: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for K: ");
            K = int.Parse(Console.ReadLine());

            array = new int[N];

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("Element[{0}]: ", index + 1);
                array[index] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            Console.WriteLine("The largest sum have the elements: ");
            for (int index = 0; index < K; index++)
            {
                Console.Write(array[(array.Length - 1 - index)]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
