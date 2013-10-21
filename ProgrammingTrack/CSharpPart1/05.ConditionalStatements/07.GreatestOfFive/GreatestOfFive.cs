using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreatestOfFive
{
    class GreatestOfFive
    {
        static void Main(string[] args)
        {
            int[] userInput = new int[5];
            int maxNumber;

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.Write("Enter value for number {0}: ", i+1);
                userInput[i] = int.Parse(Console.ReadLine());
            }
            maxNumber = userInput[0];
            for (int i = 0; i < userInput.Length; i++)
            {
                if (maxNumber < userInput[i])
                {
                    maxNumber = userInput[i];
                }
            }
            Console.WriteLine("The biggest number is: {0}", maxNumber);
        }
    }
}
