using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetMax
{
    public class GetMax
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter values for: ");

            Console.Write("First number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Third number: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("The biggest number is: {0}", GetMaxNumber(GetMaxNumber(a, b), c)); 
        }

        public static int GetMaxNumber(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
