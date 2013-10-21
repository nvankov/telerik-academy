using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AssignNullToIntAndDouble
{
    class AssignNullToIntAndDouble
    {
        static void Main(string[] args)
        {
            int? i = null;
            double? d = null;

            Console.WriteLine(i);
            Console.WriteLine(d);

            i = 5;
            d = 5.0;

            Console.WriteLine(i);
            Console.WriteLine(d);

        }
    }
}
