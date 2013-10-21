using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeValuesIfFirstGreater
{
    class ExchangeValuesIfFirstGreater
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.Write("Enter value for the first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter value for the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            Console.Write("The greater of {0} and {1} is: ", firstNumber, secondNumber);

            if (secondNumber > firstNumber)
            {
                secondNumber = secondNumber + firstNumber;
                firstNumber = secondNumber - firstNumber;
                secondNumber = secondNumber - firstNumber;
            }

            Console.WriteLine(firstNumber);
        }
    }
}
