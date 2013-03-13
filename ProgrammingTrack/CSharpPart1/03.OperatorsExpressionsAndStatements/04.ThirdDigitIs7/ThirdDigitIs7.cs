using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            int number = 1732;
            int checker = number / 100;
            checker %= 10;

            if (checker == 7)
            {
                Console.WriteLine("The third digit is seven");
            }
            else
            {
                Console.WriteLine("The third digit is not seven");
            }
        }
    }
}
