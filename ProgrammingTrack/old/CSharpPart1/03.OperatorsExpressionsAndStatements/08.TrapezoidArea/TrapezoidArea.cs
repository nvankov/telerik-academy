using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double h;

            Console.Write("Enter value for the first side: ");
            a = Double.Parse(Console.ReadLine());

            Console.Write("Enter value for the second side: ");
            b = Double.Parse(Console.ReadLine());

            Console.Write("Enter value for the height: ");
            h = Double.Parse(Console.ReadLine());

            Console.WriteLine("The trapezoid's area by gisen sides a: {0} and b: {1} and height h: {2} is {3}",
                a, b, h, (a + b) / 2 * h);


        }
    }
}
