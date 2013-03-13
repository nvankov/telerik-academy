using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.First10Numbers
{
    class First10Numbers
    {
        static void Main(string[] args)
        {
            int signHolder = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 2) * signHolder);
                signHolder *= -1;
            }
        }
    }
}
