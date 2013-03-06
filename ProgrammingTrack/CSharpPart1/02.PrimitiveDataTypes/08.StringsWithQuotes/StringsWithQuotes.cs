using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.StringsWithQuotes
{
    class StringsWithQuotes
    {
        static void Main(string[] args)
        {
            string firstString = "The \"use\" of quotations causes difficulties.";
            string secondString = @"The ""use"" of quotations causes difficulties.";
            char[] ch = {'T', 'h', 'e', ' ', '"', 'u', 's', 'e', '"', ' ', 'o', 'f', ' ',
                        'q', 'u', 'o', 't', 'a', 't', 'i', 'o', 'n', 's', ' ',
                        'c', 'a', 'u', 's', 'e', 's', ' ',
                        'd', 'i', 'f', 'f', 'i', 'c', 'u', 'l', 't', 'i', 'e', 's', '.'};
            string thirdString = new string(ch);


            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
            Console.WriteLine(thirdString);
        }
    }
}
