using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrintFrom1ToN
{
    class PrintFrom1ToN
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Please enter a value for n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
