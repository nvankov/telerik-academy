using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GenerateTenRandomValues
{
    class GenerateTenRandomValues
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            const int NUMBERS_TO_PRINT = 10;

            for (int i = 0; i < NUMBERS_TO_PRINT; i++)
            {
                Console.Write("{0} ", rand.Next(100, 200));
            }
            Console.WriteLine();
        }
    }
}
