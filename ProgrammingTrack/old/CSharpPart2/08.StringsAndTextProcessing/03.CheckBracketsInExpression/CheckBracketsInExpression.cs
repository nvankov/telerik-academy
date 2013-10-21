using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CheckBracketsInExpression
{
    class CheckBracketsInExpression
    {
        private static bool CheckExpressionBrackets(string expression)
        {
            int brackets = 0;

            foreach (var character in expression)
            {
                if (character == '(')
                {
                    brackets++;
                }
                if (character == ')')
                {
                    brackets--;
                }

                if (brackets < 0)
                {
                    return false;
                }
            }
            if (brackets != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        static void Main(string[] args)
        {
            string[] expressionsToCheck = { "((a+b)/5-d)",  ")(a+b))" , ")(2+3)/2("};

            foreach (var item in expressionsToCheck)
            {
                Console.WriteLine("Checking the expression {0}: {1}", item, CheckExpressionBrackets(item));
            }
        }
    }
}
