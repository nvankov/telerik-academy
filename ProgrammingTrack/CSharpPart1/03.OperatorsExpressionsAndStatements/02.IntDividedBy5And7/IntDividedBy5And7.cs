using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntDividedBy5And7
{
    class IntDividedBy5And7
    {
        static void Main(string[] args)
        {
            int number = 35;

            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("The number {0} can be dividet both by 5 and 7 without a remainder", number);
            }
            else
            {
                Console.WriteLine("The number {0} can not be dividet both by 5 and 7 without a remainder", number);
            }
        }
    }
}
