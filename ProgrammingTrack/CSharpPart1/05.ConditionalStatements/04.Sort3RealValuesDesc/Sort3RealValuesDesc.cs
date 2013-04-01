using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;

namespace _04.Sort3RealValuesDesc
{
    class Sort3RealValuesDesc
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            double thurdNumber;

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            firstNumber = Double.Parse(Console.ReadLine());
            secondNumber = Double.Parse(Console.ReadLine());
            thurdNumber = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thurdNumber)
                {
                    Console.WriteLine(firstNumber);
                    if (thurdNumber > secondNumber) //firstNumber > thurdNumber > secondNumber
                    {
                        Console.WriteLine(thurdNumber);
                        Console.WriteLine(secondNumber);
                    }
                    else //firstNumber > secondNumber > thurdNumber
                    {
                        Console.WriteLine(secondNumber);
                        Console.WriteLine(thurdNumber);
                    }
                }
                else //thurdNumber > firstNumber > secondNumber
                {
                    Console.WriteLine(thurdNumber);
                    Console.WriteLine(firstNumber);
                    Console.WriteLine(secondNumber);
                }

            }
            else //secondNumber > firstNumber
            {
                if (secondNumber > thurdNumber)
                {
                    Console.WriteLine(secondNumber);
                    if (firstNumber > thurdNumber) //secondNumber > firstNumber > thurdNumber
                    {
                        Console.WriteLine(firstNumber);
                        Console.WriteLine(thurdNumber);
                    }
                    else //secondNumber > thurdNumber > firstNumber
                    {
                        Console.WriteLine(thurdNumber);
                        Console.WriteLine(firstNumber);
                    }
                }

                else //thurdNumber > secondNumber > firstNumber
                {
                    Console.WriteLine(thurdNumber);
                    Console.WriteLine(secondNumber);
                    Console.WriteLine(firstNumber);
                }
            }
        }
    }
}
