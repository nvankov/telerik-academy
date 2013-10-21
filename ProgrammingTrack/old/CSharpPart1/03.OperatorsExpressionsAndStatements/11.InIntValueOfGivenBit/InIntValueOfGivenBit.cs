using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.InIntValueOfGivenBit
{
    class InIntValueOfGivenBit
    {
        static void Main(string[] args)
        {
            int i;
            int b;

            Console.Write("Please enter a value for i: ");
            i = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter the posistion of the bit to be extracted: ");
            b = Int32.Parse(Console.ReadLine());

            //if ((i & (1 << b)) == 1 << b)
            //{
            //    Console.WriteLine("The value of the bit at position {0} in the number {1} is 1", b, i);
            //}
            //else
            //{
            //    Console.WriteLine("The value of the bit at position {0} in the number {1} is 0", b, i);
            //}

            int value = (i & 1 << b);
            value >>= b;
            Console.WriteLine("The value of the bit at position {0} in the number {1} is {2}", b, i, value);

        }
    }
}
