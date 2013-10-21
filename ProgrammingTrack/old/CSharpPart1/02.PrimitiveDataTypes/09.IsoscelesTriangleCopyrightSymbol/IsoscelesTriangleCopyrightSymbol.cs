using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IsoscelesTriangleCopyrightSymbol
{
    class IsoscelesTriangleCopyrightSymbol
    {
        static void Main(string[] args)
        {
            char ch = '\u00A9';
            for (int i = 1; i < 7; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(ch);
                    Console.Write(" ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
