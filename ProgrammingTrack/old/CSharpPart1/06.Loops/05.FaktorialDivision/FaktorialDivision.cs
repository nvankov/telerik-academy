using System;
using System.Numerics;

namespace _05.FaktorialDivision
{
    class FaktorialDivision
    {
        static void Main(string[] args)
        {
            int k;
            int n;
            BigInteger nFactirial = 1;
            BigInteger kFactorial = 1;
            BigInteger kMinusNFactorial = 1;

            Console.WriteLine("Enter values for N and K so that: 1 < N < K :");

            Console.Write("K = ");
            k = Int32.Parse(Console.ReadLine());
            Console.Write("N = ");
            n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= k; i++)
            {
                nFactirial *= i;
                if (i <= n)
                {
                    kFactorial *= i;
                }
                if (i <= (k - n))
                {
                    kMinusNFactorial *= i;
                }
            }
            Console.WriteLine("{0}! * {1}! / ({0} - {1})! = {2}", k, n, (nFactirial * kFactorial) / kMinusNFactorial);
        }
    }
}
