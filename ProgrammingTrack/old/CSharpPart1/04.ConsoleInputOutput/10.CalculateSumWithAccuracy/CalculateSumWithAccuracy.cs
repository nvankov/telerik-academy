using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CalculateSumWithAccuracy
{
    class CalculateSumWithAccuracy
    {
        static void Main(string[] args)
        {
            double oldSum = 1.0;
            double newSum = 1.0;
            double denominator = 2.0;
            double sumDifference;

            do
            {
                oldSum = newSum;

                if (denominator % 2 == 0)
                {
                    newSum += ((double)1 / denominator);
                }
                else
                {
                    newSum -= ((double)1 / denominator);
                }

                denominator++;
                sumDifference = (double)Math.Abs(newSum - oldSum);

            } while (sumDifference >= 0.001);

            Console.WriteLine("The sum is {0}", newSum);
        }
    }
}
