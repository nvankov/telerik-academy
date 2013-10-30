using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderSubstring
{
    class StringBuilderSubstringTest
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            StringBuilder strSubstring;
            str.Append("Lorem ipsum dolor sit amet," + 
            " consectetur adipiscing elit. Cras leo ante, fermentum in nunc non, viverra convallis augue. Nulla facilisi.");
            strSubstring = str.Substring(0, 11);

            Console.WriteLine(strSubstring.ToString());
        }
    }
}
