using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintNotDivisibleTo3And7
{
    class PrintNotDivisibleTo3And7
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter how much numbers you want printed: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
