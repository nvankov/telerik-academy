using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            double d = 34.567839023; //float loses precision
            float f = 12.345f;
            double d2 = 8923.1234857; //float loses precision
            float f2 = 3456.091f;

            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(d2);
            Console.WriteLine(f2);
        }
    }
}
