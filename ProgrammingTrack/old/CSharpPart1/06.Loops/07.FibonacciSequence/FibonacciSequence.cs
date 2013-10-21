using System;
using System.Numerics;

namespace _07.FibonacciSequence
{
    class FibonacciSequence
    {
        static void Main(string[] args)
        {
            int userInput;
            BigInteger sum = 0;
            BigInteger firstNumber = 0;
            BigInteger secondNumber = 1;

            userInput = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < userInput; i++)
            {
                sum = firstNumber + secondNumber;
                firstNumber = firstNumber + secondNumber;
                secondNumber = secondNumber + firstNumber;
            }

            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
