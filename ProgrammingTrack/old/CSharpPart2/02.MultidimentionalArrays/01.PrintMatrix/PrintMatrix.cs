using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintMatrix
{
    class PrintMatrix
    {
        static void Main(string[] args)
        {
            int[,] array;
            int col;
            int row;

            int userInput;
            int arrayElementValue = 1;


            Console.Write("Enter a number for the dimensions of the matrix: ");
            userInput = int.Parse(Console.ReadLine());

            array = new int[userInput, userInput];

            #region a)

            for (col = 0; col < array.GetLength(1); col++)
            {
                for (row = 0; row < array.GetLength(0); row++)
                {
                    array[row, col] = arrayElementValue;
                    arrayElementValue++;
                }
            }
            PrintArray(array);

            #endregion

            Console.WriteLine();

            #region b)
            arrayElementValue = 1;
            bool isIndexAccending = true;
            row = 0;
            col = 0;

            while (arrayElementValue < array.Length)
            {
                if (isIndexAccending)
                {
                    while (row < 4)
                    {
                        array[row, col] = arrayElementValue;
                        row++;
                        arrayElementValue++;

                        if (row == 4)
                        {
                            isIndexAccending = false;
                            col++;
                        }
                    }
                }

                if (!isIndexAccending)
                {
                    while (row > 0)
                    {
                        row--;
                        array[row, col] = arrayElementValue;
                        arrayElementValue++;

                        if (row == 0)
                        {
                            isIndexAccending = true;
                            col++;
                        }
                    }
                }
            }

            PrintArray(array);

            #endregion


        }

        private static void PrintArray(int[,] array)
        {
            int row;
            int col;

            for (row = 0; row < array.GetLength(0); row++)
            {
                for (col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write("{0, -2}", array[row, col]);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
