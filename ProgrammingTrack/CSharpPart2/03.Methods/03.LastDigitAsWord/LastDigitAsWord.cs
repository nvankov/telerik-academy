using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastDigitAsWord
{
    class LastDigitAsWord
    {
        static string LastDigitAsString(int number)
        {
            int lastDigit = number % 10;

            switch (lastDigit)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 0:
                    return "zero";
                default:
                    return "invalid format";
            }
        }

        static void Main(string[] args)
        {
            int userInput;
            Console.Write("Please enter a number: ");
            userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("The last digit is: {0}", LastDigitAsString(userInput));
        }
    }
}
