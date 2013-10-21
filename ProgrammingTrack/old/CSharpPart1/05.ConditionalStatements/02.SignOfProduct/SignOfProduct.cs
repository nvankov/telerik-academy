using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SignOfProduct
{
    class SignOfProduct
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Enter value for the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter value for the second number: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter value for the third number: ");
            c = int.Parse(Console.ReadLine());

            if (a < 0) // a < 0
            {
                if (b < 0) // a < 0; b < 0
                {
                    if (c < 0) // a < 0; b < 0; c < 0
                    {
                        Console.WriteLine("Minus");
                    }
                    else // a < 0; b < 0; c > 0
                    {
                        Console.WriteLine("Plus");
                    }
                }
                else //a < 0; b > 0
                {
                    if (c < 0) //a < 0; b > 0; c < 0
                    {
                        Console.WriteLine("Plus");
                    }
                    else //a < 0; b > 0; c > 0
                    {
                        Console.WriteLine("Minus");
                    }
                }
            }
            else //a > 0
            {
                if (b < 0) //a > 0; b < 0
                {
                    if (c < 0) //a > 0; b < 0; c < 0
                    {
                        Console.WriteLine("Plus");
                    }
                    else //a > 0; b < 0; c > 0
                    {
                        Console.WriteLine("Minus");
                    }
                }
                else //a > 0; b > 0
                {
                    if (c < 0) //a > 0; b > 0; c < 0
                    {
                        Console.WriteLine("Minus");
                    }
                    else //a > 0; b > 0; c > 0
                    {
                        Console.WriteLine("Plus");
                    }
                }
            }
        }
    }
}
