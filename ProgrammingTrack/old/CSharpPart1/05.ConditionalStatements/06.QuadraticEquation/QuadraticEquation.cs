using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());

            double d = (b * b - 4 * a * c);
            if (d > 0)
            {
                double x1 = ((-1) * b + Math.Sqrt(d)) / 2;
                double x2 = ((-1) * b - Math.Sqrt(d)) / 2;

                Console.WriteLine("x1 is {0}", x1);
                Console.WriteLine("x2 is {0}", x2);
            }

            else
            {
                if (d == 0)
                {
                    double x = (-b) / 2 * a;
                    Console.WriteLine("There is only one root to this equation: {0}", x);
                }
                else
                {
                    Console.WriteLine("There is no solution!");
                }
            }
        }
    }
}
