using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PrintASCIICharacters
{
    class PrintASCIICharacters
    {
        static void Main(string[] args)
        {
            for (int i = 32; i < 127; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
