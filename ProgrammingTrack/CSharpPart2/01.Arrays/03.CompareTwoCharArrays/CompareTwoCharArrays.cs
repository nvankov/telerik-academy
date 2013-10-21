using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareTwoCharArrays
{
    class CompareTwoCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArray = { 'a', 'b', 'c', 'd', 'e'};
            char[] secondArray = { 'a', 'c', 'b', 'f', 'q'};

            Console.Write("The first char array: ");

            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write("{0} ", firstArray[index]);
            }
            Console.WriteLine();

            Console.Write("The second char array: ");

            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write("{0} ", secondArray[index]);
            }
            Console.WriteLine();

            Console.WriteLine("Comparing the two arrays: ");
            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write("Comparing at position {0}: ", index);

                if (firstArray[index] == secondArray[index])
                {
                    Console.WriteLine("The elements are identical ({0}).", firstArray[index]);
                }
                else
                {
                    if (firstArray[index] > secondArray[index])
                    {
                        Console.WriteLine("The first element is after the second ({0} > {1}).", 
                            firstArray[index], secondArray[index]);
                    }
                    else
                    {
                        Console.WriteLine("The first element is before the second ({0} < {1}).",
                            firstArray[index], secondArray[index]);
                    }
                }
            }
        }
    }
}
