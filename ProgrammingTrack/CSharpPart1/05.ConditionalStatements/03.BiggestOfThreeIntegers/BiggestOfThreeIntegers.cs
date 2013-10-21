using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BiggestOfThreeIntegers
{
    class BiggestOfThreeIntegers
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Enter a value for the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for the second number: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for the third number: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("{0} is bigger", a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine("{0} is bigger", b);
            }
            if (c > a && c > b)
            {
                Console.WriteLine("{0} is bigger", c);
            }
        }
    }
}
