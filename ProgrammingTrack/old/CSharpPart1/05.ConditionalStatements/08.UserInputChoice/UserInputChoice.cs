using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.UserInputChoice
{
    class UserInputChoice
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int intVariable = random.Next(1, 100);
            double doubleVariable = random.NextDouble() * (100.00 - 1.00) + 1.00;
            string stringVariable = "This is the string";
            string userChoice;

            Console.WriteLine("Enter a choice: ");
            Console.Write(@"""int"" for integer variable ""double"" for double variable and ""string"" for string variable: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "int":
                    intVariable += 1;
                    Console.WriteLine("The int variable is: {0}", intVariable);
                    break;
                case "double":
                    doubleVariable += 1;
                    Console.WriteLine("The double variable is: {0}", doubleVariable);
                    break;
                case "string":
                    stringVariable += "*";
                    Console.WriteLine("The string variable is: {0}", stringVariable);
                    break;
                default:
                    Console.WriteLine("Invalid user input!");
                    break;
            }
        }
    }
}
