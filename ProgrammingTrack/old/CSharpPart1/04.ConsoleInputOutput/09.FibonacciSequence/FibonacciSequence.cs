using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FibonacciSequence
{
    class FibonacciSequence
    {
        static void Main(string[] args)
        {
            uint firstNumber = 0;
            uint secondNumber = 1;

            for (int i = 0; i < 100; i++)
            {
                Console.Write(firstNumber + " ");
                Console.Write(secondNumber + " ");

                firstNumber += secondNumber;
                secondNumber += firstNumber;
            }
        }
    }
}
