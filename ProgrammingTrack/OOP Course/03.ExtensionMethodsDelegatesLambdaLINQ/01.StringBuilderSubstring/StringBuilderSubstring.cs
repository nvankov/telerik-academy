using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderSubstring
{
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            if (startIndex + length + 1 >= input.Length || startIndex < 0 || length < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid start and/or lenght.");
            }

            StringBuilder sb = new StringBuilder();
            for (int index = startIndex; index < startIndex + length; index++)
            {
                sb.Append(input[index]);
            }

            return sb;
        }
    }
}
