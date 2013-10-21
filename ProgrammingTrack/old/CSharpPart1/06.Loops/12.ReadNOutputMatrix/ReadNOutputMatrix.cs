using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ReadNOutputMatrix
{
    class ReadNOutputMatrix
    {
        static void Main(string[] args)
        {
            int n;
            int[,] array;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0, v = i; j < n; j++, v++)
                {
                    array[i, j] = v + 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("|");
                    Console.Write(array[i, j]);
                    
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
