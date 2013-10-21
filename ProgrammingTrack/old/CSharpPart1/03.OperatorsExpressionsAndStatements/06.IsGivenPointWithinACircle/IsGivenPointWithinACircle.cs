using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IsGivenPointWithinACircle
{
    class IsGivenPointWithinACircle
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;

            if (x*x + y*y <= 5)
            {
                Console.WriteLine("The point is in the circle");
            }
            else
            {
                Console.WriteLine("The point is not in the circle");
            }
        }
    }
}
