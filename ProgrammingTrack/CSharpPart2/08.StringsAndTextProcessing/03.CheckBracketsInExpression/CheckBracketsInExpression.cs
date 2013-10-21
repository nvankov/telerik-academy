using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CheckBracketsInExpression
{
    class CheckBracketsInExpression
    {
        static bool CheckBracketsOrder(string expression)
        {
            int bracketsCount = 0;

            for (int index = 0; index < expression.Length; index++)
            {
                if (expression[index] == '(')
                {
                    bracketsCount++;
                }

                if (expression[index] == ')')
                {
                    bracketsCount--;
                }

                if (bracketsCount < 0)
                {
                    return false;
                }
            }

            if (bracketsCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            string expression;

            Console.Write("Enter an expression to check if the brackets are put correctly: ");
            expression = Console.ReadLine();

            Console.WriteLine("Checking if the brackets are put in the correct order: {0}", CheckBracketsOrder(expression));
        }
    }
}
