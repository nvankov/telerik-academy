using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxSumOfSquareInMatrix
{
    class MaxSumOfSquareInMatrix
    {
        static void Main(string[] args)
        {
            int rows;
            int cols;
            int startingRow = 0;
            int startingCol = 0;
            int maxSum = int.MinValue;
            int[,] array;

            Console.Write("Enter number of rows: ");
            rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of colums: ");
            cols = int.Parse(Console.ReadLine());

            array = new int[rows, cols];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write("Enter value for element[{0},{1}]: ", row, col);
                    array[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < array.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < array.GetLength(1) - 2; col++)
                {
                    int sum = array[row,col] + array[row + 1,col] + array[row + 2,col]
                        + array[row,col + 1] + array[row,col + 2];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        startingRow = row;
                        startingCol = col;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Array: ");

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write("{0, -3}", array[row, col]);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("The biggest sum is: {0}", maxSum);
            Console.WriteLine("The square with max sum is: ");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("{0, -3}", array[startingRow + row, startingCol + col]); 
                }
                Console.WriteLine();
            }
        }
    }
}
