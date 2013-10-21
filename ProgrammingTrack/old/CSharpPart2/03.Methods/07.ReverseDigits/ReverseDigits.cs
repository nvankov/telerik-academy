using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseDigits
{
    class ReverseDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReversedNumber(123456789));
        }

        public static int ReversedNumber(int number)
        {
            char[] digits = number.ToString().ToCharArray();
            char[] reversedDigits = new char[digits.Length];

            for (int index = 0; index < digits.Length; index++)
            {
                reversedDigits[index] = digits[digits.Length - 1 - index];
            }

            string str = new string(reversedDigits);
            int reversedNumber = int.Parse(str);

            return reversedNumber;
        }
    }
}
