using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BonusScores
{
    class BonusScores
    {
        static void Main(string[] args)
        {
            int userInput;

            do
            {
                Console.Write("Enter a number between 1 and 9: ");
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                    case 2:
                    case 3:
                        userInput *= 10;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        userInput *= 100;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        userInput *= 1000;
                        break;
                    default:
                        userInput = 0;
                        Console.WriteLine("Error: User input is not between 1 and 9");
                        break;
                }
            } while (userInput == 0);

            Console.WriteLine("New value is: {0}", userInput);

        }
    }
}
