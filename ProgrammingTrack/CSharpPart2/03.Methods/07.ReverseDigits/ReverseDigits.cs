using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseDigits
{
    class ReverseDigits
    {
        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            return reversed;
        }

        static decimal ReverseNumber(decimal number)
        {
            string reversed = number.ToString();
            reversed = ReverseString(reversed);
            decimal reversedNumber = decimal.Parse(reversed);

            return reversedNumber;
        }

        static void Main(string[] args)
        {
            decimal userChoice;
            Console.Write("Enter a decimal number: ");
            userChoice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The reversed number is: {0}", ReverseNumber(userChoice));
        }
    }
}
