using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersPBetweenTwoIntegers
{
    class NumbersPBetweenTwoIntegers
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int p = 0;

            do
            {
                Console.Write("Enter a positive value for the first number: ");
                firstNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter a positive value for the second number: ");
                secondNumber = int.Parse(Console.ReadLine());
            } while ((firstNumber <= 0 || secondNumber <= 0) || firstNumber > secondNumber);

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }

            Console.WriteLine("Number of p number that exit between {0} and {1} and are divided by 5: {2}", 
                firstNumber, secondNumber, p);

        }
    }
}
