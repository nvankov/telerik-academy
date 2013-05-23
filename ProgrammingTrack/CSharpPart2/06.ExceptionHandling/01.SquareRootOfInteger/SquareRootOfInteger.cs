using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRootOfInteger
{
    class SquareRootOfInteger
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.Write("Enter a non-negative integer: ");

            try
            {
                userInput = int.Parse(Console.ReadLine());
                Console.WriteLine(SquareRoot(userInput));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Input can not be null!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input format!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The value entered is too big for an integer!");
            }
            catch (ArithmeticException ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }


        }


        static double SquareRoot(int number)
        {
            if (number < 0)
            {
                throw new ArithmeticException("Can't calculate the square root of a negative number!");
            }
            else
            {
                return Math.Sqrt(number);
            }
        }
    }
}
