using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintMatrixNxN
{
    class PrintMatrixNxN
    {
        static void Main(string[] args)
        {
            
            #region a)
            /*
            int matrixSize;
            int[,] array;
            int number = 1;

            Console.Write("Enter size for the matrix: ");
            matrixSize = int.Parse(Console.ReadLine());

            array = new int[matrixSize, matrixSize];

            for (int cols = 0; cols < array.GetLength(1); cols++)
            {
                for (int rows = 0; rows < array.GetLength(0); rows++)
                {
                    array[rows, cols] = number;
                    number++;
                }
            }

            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                for (int cols = 0; cols < array.GetLength(1); cols++)
                {
                    Console.Write("{0} ", array[rows, cols]);
                }

                Console.WriteLine();
            }
            */
            #endregion

            #region b)
            /*
            int matrixSize;
            int[,] array;
            int number = 1;

            Console.Write("Enter size for the matrix: ");
            matrixSize = int.Parse(Console.ReadLine());

            array = new int[matrixSize, matrixSize];

            for (int cols = 0; cols < array.GetLength(1); cols++)
            {
                for (int rows = 0; rows < array.GetLength(0); rows++)
                {
                    if (cols % 2 == 1)
                    {
                        array[(array.GetLength(0) - 1 - rows), cols] = number;
                    }
                    else
                    {
                        array[rows, cols] = number;
                    }
                    
                    number++;
                }
            }

            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                for (int cols = 0; cols < array.GetLength(1); cols++)
                {
                    Console.Write("{0} ", array[rows, cols]);
                }

                Console.WriteLine();
            }
            */
            #endregion

            #region c)

            int matrixSize = 4;
            int[,] array;
            int number = 1;
            int startRow;
            int startCol = 0;
            int row;
            int col = 0;

            //Console.Write("Enter size for the matrix: ");
            //matrixSize = int.Parse(Console.ReadLine());

            array = new int[matrixSize, matrixSize];

            startRow = array.GetLength(1) - 1;
            array[array.GetLength(1) - 1, 0] = number;
            number++;

            row = startRow;
            while (col < array.GetLength(1))
            {
                startRow--;
                if (startRow >= 0)
                {
                    row = startRow;


                    while (row < array.GetLength(0))
                    {
                        array[row, col] = number;
                        number++;
                        row++;
                        col++;

                        //if (row >= array.GetLength(0) - 1 || col >= array.GetLength(1) - 1)
                        //{
                        //    break;
                        //}
                    }

                    col = 0;

                }
                else
                {
                    row = 0;
                    startCol++;
                    col = startCol;

                    while (col < array.GetLength(1))
                    {
                        array[row, col] = number;
                        row++;
                        col++;
                        number++;
                    }

                    

                }


                
            }

            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                for (int cols = 0; cols < array.GetLength(1); cols++)
                {
                    Console.Write("{0} ", array[rows, cols]);
                }

                Console.WriteLine();
            }

            #endregion

        }
    }
}
