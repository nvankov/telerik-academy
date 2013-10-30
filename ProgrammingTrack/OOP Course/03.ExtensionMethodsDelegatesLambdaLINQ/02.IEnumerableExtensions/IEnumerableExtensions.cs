using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensions
{
    class IEnumerableExtensions
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 4, 45, 67, 25};
            Console.WriteLine("Sum of int array is: {0}", intArray.Sum());
            Console.WriteLine("Product of int array is: {0}", intArray.Product());
            Console.WriteLine("Min value is: {0}", intArray.Min());
            Console.WriteLine("Max value is: {0}", intArray.Max());
            Console.WriteLine("Average value is: {0}", intArray.Average());

        }
    }
}
