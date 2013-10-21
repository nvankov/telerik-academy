using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastDigitAsWord
{
    class LastDigitAsWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Last digit of the number {0} is: {1}", 1459, LastDigitAsString(1459));
        }

        public static string LastDigitAsString(int userNumber)
        {
            string str = userNumber.ToString();
            char lastDigit = str[str.Length-1];

            switch (lastDigit)
            {
                case '1':
                    return "one";
                    break;
                case '2':
                    return "two";
                    break;
                case '3':
                    return "three";
                    break;
                case '4':
                    return "four";
                    break;
                case '5':
                    return "five";
                    break;
                case '6':
                    return "six";
                    break;
                case '7':
                    return "seven";
                    break;
                case '8':
                    return "eight";
                    break;
                case '9':
                    return "nine";
                    break;
                case '0':
                    return "zero";
                    break;
                default:
                    return "Not a valid number";
                    break;
            }
        }
    }
}
