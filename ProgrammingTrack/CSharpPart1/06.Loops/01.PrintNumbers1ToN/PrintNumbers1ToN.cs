using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintNumbers1ToN
{
    class PrintNumbers1ToN
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter how much numbers you want printed: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
