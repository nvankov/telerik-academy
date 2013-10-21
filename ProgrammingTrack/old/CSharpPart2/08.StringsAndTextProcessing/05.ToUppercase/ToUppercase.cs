﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.ToUppercase
{
    class ToUppercase
    {



        static void Main(string[] args)
        {
            string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            Console.WriteLine(Regex.Replace(str, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
        }
    }
}
