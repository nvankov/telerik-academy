using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CheckForSubstringOccurances
{
    class CheckForSubstringOccurances
    {
        static int CheckSubstringCount(string text, string substring)
        {
            int index = 0;
            int count = 0;
            string textToLover = text.ToLower();
            string substringToLover = substring.ToLower();

            while (index != -1)
            {
                index = textToLover.IndexOf(substringToLover, index + 1);

                if (index != -1)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            string text;
            string substring;

            Console.Write("Enter a text: ");
            text = Console.ReadLine();

            Console.Write("Enter a substring to look for: ");
            substring = Console.ReadLine();

            Console.WriteLine("Number of occurances: {0}", CheckSubstringCount(text, substring));
        }
    }
}
