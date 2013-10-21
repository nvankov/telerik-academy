using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BitAtPositionP
{
    class BitAtPositionP
    {
        static void Main(string[] args)
        {
            int p;
            int v;
            

            Console.Write("Enter a value for the number v: ");
            v = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a value for the position p: ");
            p = Int32.Parse(Console.ReadLine());

            //int mask = 1;
            //int vAndMask;
            //mask <<= p;
            //vAndMask = v & mask;
            //vAndMask >>= p;

            //Console.WriteLine("Check if the bit in position p({0}), in number v({1}) is 1: {2}",
            //    p, v, (vAndMask == 1 ) ? true : false);

            Console.Write("Check if the bit in position p({0}), in number v({1}) is 1: ", p, v);
            if ((v & (1 << p)) == 1 << p)
                Console.WriteLine(true);
            else Console.WriteLine(false);


        }
    }
}
