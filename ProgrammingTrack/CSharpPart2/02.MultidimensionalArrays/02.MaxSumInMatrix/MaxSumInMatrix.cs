using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxSumInMatrix
{
    class MaxSumInMatrix
    {
        static void Main(string[] args)
        {
            int N;
            int M;
            int maxSum = int.MinValue;
            int sum = 0;
            int[,] array;
            Random rand = new Random();

            Console.WriteLine("Please enter dimensions for the matrix");

            Console.Write("N = ");
            N = int.Parse(Console.ReadLine());

            Console.Write("M = ");
            M = int.Parse(Console.ReadLine());

            array = new int[N, M];

            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                for (int cols = 0; cols < array.GetLength(1); cols++)
                {
                    array[rows, cols] = rand.Next(1, 5);
                }
            }

            //Printing Array
            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                for (int cols = 0; cols < array.GetLength(1); cols++)
                {
                    Console.Write("{0} ", array[rows, cols]);
                }
                Console.WriteLine();
            }

            for (int rows = 0; rows < array.GetLength(0) - 2; rows++)
            {
                for (int cols = 0; cols < array.GetLength(1) - 2; cols++)
                {
                    //Calculating Sum
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sum += array[(rows + i), (cols + j)];
                        }
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }

                    sum = 0;
                }
            }

            Console.WriteLine("Mas sum is: {0}", maxSum);
        }
    }
}
