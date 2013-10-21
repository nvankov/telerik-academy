using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SafelyCompareFloatVariables
{
    class SafelyCompareFloatVariables
    {
        static void Main(string[] args)
        {
            float f1 = 5.3f;
            float f2 = 6.01f;

            Console.WriteLine("Check if {0} and {1} are equal: {2}", f1, f2, 
                (Math.Abs(f1 - f2) < 0.000001) | (Math.Abs(f2 - f1) < 0.000001));

            float f3 = 5.00000001f;
            float f4 = 5.00000003f;

            Console.WriteLine("Check if {0} and {1} are equal: {2}", f1, f2,
                (Math.Abs(f1 - f2) < 0.000001) | (Math.Abs(f3 - f4) < 0.000001));
        }
    }
}
