using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindOccurrencesOfSubstring
{
    class FindOccurrencesOfSubstring
    {
        private static int NumberOfSubstringOccurrences(string mainString, string substring)
        {
            string lowercaseString = mainString.ToLower();
            string lowerSubstring = substring.ToLower();
            int index = -1;
            int count = 0;

            while (true)
            {
                index = lowercaseString.IndexOf(lowerSubstring, index + 1);
                if (index == -1)
                {
                    break;
                }
                count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else."
            + "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string substring = "in";

            Console.WriteLine("Number of occurrences: {0}", NumberOfSubstringOccurrences(text, substring));
        }
    }
}
