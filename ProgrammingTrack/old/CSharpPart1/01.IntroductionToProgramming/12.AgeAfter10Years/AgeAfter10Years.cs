using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            uint userAge;
            Console.Write("Please enter your age: ");
            userAge = (uint)Int32.Parse(Console.ReadLine());

            Console.WriteLine("In ten years you'll be {0} years old", (userAge + 10));
        }
    }
}
