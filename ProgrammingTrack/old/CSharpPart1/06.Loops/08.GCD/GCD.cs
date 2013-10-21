using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int residueDivision;

            Console.WriteLine("Enter value for first and second number: ");

            Console.Write("First number: ");
            firstNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            secondNumber = Int32.Parse(Console.ReadLine());

            for (residueDivision = firstNumber % secondNumber;
                residueDivision != 0;
                firstNumber = secondNumber, secondNumber = residueDivision, residueDivision = firstNumber % secondNumber) ;

            Console.WriteLine("GCD is: {0}", secondNumber);
        }
    }
}
