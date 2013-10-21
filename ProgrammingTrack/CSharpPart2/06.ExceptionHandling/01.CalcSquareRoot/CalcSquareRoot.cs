using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalcSquareRoot
{
    class CalcSquareRoot
    {
        static double SquareRoot(string userNumber)
        {
            int number;
            
            //Parses the string. If the parsing fails it throws an exception
            if (!int.TryParse(userNumber, out number))
            {
                throw new FormatException("The passed argument is not a number");
            }
            else
            {
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("userNumber", "The number cannot be smaller than zero.");
                }
                return Math.Sqrt(number);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                string userInput = Console.ReadLine();
                double result = SquareRoot(userInput);
                Console.WriteLine(result);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number: {0}", fe.Message);
            }
            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine("Invalid number: {0}", ae.Message);
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
            
            
        }
    }
}
