using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DivisibleBy3Or7
{
    class DivisibleBy3Or7
    {
        static void Main(string[] args)
        {
            List<int> numbersArray = new List<int>() { 1, 3, 5, 6, 87, 54, 513, 77, 21, 64, 56, 66, 21, 441 };
            var divisible = numbersArray.FindAll(number => number % 21 == 0);

            //int[] numbersArray = { 1, 3, 5, 6, 87, 54, 513, 77, 21, 64, 56, 66, 21, 441 };
            //var divisible = numbersArray.Where(x => x % 21 == 0);

            Console.WriteLine();
            foreach (var item in divisible)
            {
                Console.WriteLine(item);
            }

            //With LINQ
            var LinqDivisible =
                from number in numbersArray
                where number % 21 == 0
                select number;

            Console.WriteLine();

            foreach (var item in LinqDivisible)
            {
                Console.WriteLine(item);
            }
        }
    }
}
