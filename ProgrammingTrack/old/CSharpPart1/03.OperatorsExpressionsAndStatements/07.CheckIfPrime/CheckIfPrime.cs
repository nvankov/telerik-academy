using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CheckIfPrime
{
    class CheckIfPrime
    {
        static void Main(string[] args)
        {
            int number;
            bool isPrime = true;

            Console.Write("Enter a number to be checked (must be below 100): ");
            do
            {
                number = Int32.Parse(Console.ReadLine());
                if (number > 100)
                {
                    Console.WriteLine("Please enter a different number: ");
                }
                if (number == 0)
                {
                    Console.WriteLine("The number must not be zero!");
                }
            } while (number <= 100 || number == 0);

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("The number {0} is a prime number", number);
            }
            else
            {
                Console.WriteLine("The number {0} is a composite number", number);
            }
        }
    }
}
