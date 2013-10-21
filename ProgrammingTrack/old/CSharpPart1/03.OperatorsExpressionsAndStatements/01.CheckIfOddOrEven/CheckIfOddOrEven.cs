using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CheckIfOddOrEven
{
    class CheckIfOddOrEven
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number: ");
            number = Int32.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            if (number % 2 != 0)
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
