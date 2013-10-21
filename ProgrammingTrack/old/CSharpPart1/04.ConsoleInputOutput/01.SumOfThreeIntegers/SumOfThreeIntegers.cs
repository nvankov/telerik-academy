using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumOfThreeIntegers
{
    class SumOfThreeIntegers
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Enter value for the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter value for the second number number: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter value for the third number: ");
            c = int.Parse(Console.ReadLine());

            int sum = a + b + c;
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
