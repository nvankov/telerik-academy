using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculateSumOfNNumbers
{
    class CalculateSumOfNNumbers
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;

            Console.Write("Enter a value for n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number({0})", i+1);
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Total sum: {0}", sum);
        }
    }
}
