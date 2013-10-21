using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdBitIs1Or0
{
    class ThirdBitIs1Or0
    {
        static void Main(string[] args)
        {
            int number = 568;
            int mask = 1;
            int nAndMask;

            mask = mask << 3;
            nAndMask = number & mask;
            nAndMask = nAndMask >> 3;

            Console.WriteLine("The third bit in number {0} is {1}", number, nAndMask);

        }
    }
}
