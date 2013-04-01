using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GreaterOfTwo
{
    class GreaterOfTwo
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Enter a value for the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for the second number: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("The greater number is: {0}", (a > b ? a : b));
        }
    }
}
