using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExchangeIntValues
{
    class ExchangeIntValues
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 10;

            Console.WriteLine("First number is {0} and second is this {1}", firstNumber, secondNumber);

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine("First number is {0} and second is this {1}", firstNumber, secondNumber);
        }
    }
}
