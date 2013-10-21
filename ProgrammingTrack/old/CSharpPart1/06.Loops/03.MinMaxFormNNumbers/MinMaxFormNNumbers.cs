using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxFormNNumbers
{
    class MinMaxFormNNumbers
    {
        static void Main(string[] args)
        {
            int n;
            int tempVariable;
            int min = int.MaxValue;
            int max = int.MinValue;

            Console.Write("Enter how much numbers you want to submit: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                tempVariable = int.Parse(Console.ReadLine());

                if (min > tempVariable)
                {
                    min = tempVariable;
                }
                if (max < tempVariable)
                {
                    max = tempVariable;
                }
            }

            Console.WriteLine("Min value is: {0}", min);
            Console.WriteLine("Max value is: {0}", max);
        }
    }
}
