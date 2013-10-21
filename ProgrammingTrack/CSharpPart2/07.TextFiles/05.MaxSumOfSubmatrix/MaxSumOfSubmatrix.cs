using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.MaxSumOfSubmatrix
{
    class MaxSumOfSubmatrix
    {
        const string MATRIXFILE = "matrix.txt";

        static public int[,] ExtraxtMatrixFromFile(string file)
        {
            int size = 0;
            int[,] matrix;

            using (StreamReader reader = new StreamReader(file))
            {
                size = int.Parse(reader.ReadLine());
                matrix = new int[size, size];

                for (int line = 0; line < matrix.GetLength(0); line++)
                {
                    string row = reader.ReadLine();
                    string[] rowElements = row.Split(' ');

                    for (int element = 0; element < matrix.GetLength(1); element++)
                    {
                        matrix[line, element] = int.Parse(rowElements[element]);
                    }
                }

                return matrix;
            }
        }

        static int BiggestSumOfSubmatrix(int[,] matrix, int size = 2)
        {
            int sum = 0;
            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - size + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - size + 1; col++)
                {

                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            sum += matrix[row + i, col + j];
                        }
                    }

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }

                    sum = 0;
                }
            }

            return bestSum;
        }

        static void Main(string[] args)
        {
            int[,] array = ExtraxtMatrixFromFile(MATRIXFILE);
            int sum = BiggestSumOfSubmatrix(array, 2);
            Console.WriteLine(sum);
        }
    }
}
