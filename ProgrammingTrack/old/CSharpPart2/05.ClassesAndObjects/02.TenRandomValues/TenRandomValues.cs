using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TenRandomValues
{
    class TenRandomValues
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(rand.Next(100, 201));
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
