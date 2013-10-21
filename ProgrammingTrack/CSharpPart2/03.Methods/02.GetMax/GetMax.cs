using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetMax
{
    class GetMax
    {
        static int GetMaxMethod(int a, int b)
        { 
            return (a > b? a: b);
        }

        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;

            Console.WriteLine("Please enter...");
            Console.Write("The first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("The second number: ");
            secondNumber= int.Parse(Console.ReadLine());

            Console.Write("The third number: ");
            thirdNumber = int.Parse(Console.ReadLine());

            int maxNumber = GetMaxMethod(firstNumber, secondNumber);
            maxNumber = GetMaxMethod(maxNumber, thirdNumber);

            Console.WriteLine("The biggest number is: {0}", maxNumber);
        }
    }
}
