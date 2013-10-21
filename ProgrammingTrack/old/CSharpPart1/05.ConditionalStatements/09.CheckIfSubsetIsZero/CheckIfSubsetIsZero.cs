using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CheckIfSubsetIsZero
{
    class CheckIfSubsetIsZero
    {
        static void Main(string[] args)
        {
            int[] userNumbers = new int[5];
            int i;
            Console.WriteLine("Enter:");

            for (i = 0; i < userNumbers.Length; i++)
            {
                Console.Write("Value for number{0}: ", i + 1);
                userNumbers[i] = int.Parse(Console.ReadLine());
            }

            if (userNumbers[0] + userNumbers[1] + userNumbers[2] == 0)
            {
                Console.WriteLine("The subset of {0}, {1} and {2} is zero", userNumbers[0], userNumbers[1], userNumbers[2]);
            }

            for (i = 0; i < 3; i++)
            {
                if (userNumbers[0] + userNumbers[1 + i] + userNumbers[4] == 0)
                {
                    Console.WriteLine("The subset of {0}, {1} and {2} is zero", userNumbers[0], userNumbers[1 + i], userNumbers[4]);
                }
            }

            for (i = 0; i < 2; i++)
            {
                if (userNumbers[0] + userNumbers[1 + i] + userNumbers[3] == 0)
                {
                    Console.WriteLine("The subset of {0}, {1} and {2} is zero", userNumbers[0], userNumbers[1 + i], userNumbers[3]);
                }
            }

            for (i = 0; i < 2; i++)
            {
                if (userNumbers[1] + userNumbers[2 + i] + userNumbers[4] == 0)
                {
                    Console.WriteLine("The subset of {0}, {1} and {2} is zero", userNumbers[1], userNumbers[2 + i], userNumbers[4]);
                }
            }

            if (userNumbers[1] + userNumbers[2] + userNumbers[3] == 0)
            {
                Console.WriteLine("The subset of {0}, {1} and {2} is zero", userNumbers[1], userNumbers[2], userNumbers[3]);
            }

            if (userNumbers[2] + userNumbers[3] + userNumbers[4] == 0)
            {
                Console.WriteLine("The subset of {0}, {1} and {2} is zero", userNumbers[2], userNumbers[3], userNumbers[4]);
            }
        }
    }
}
