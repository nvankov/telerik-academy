using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.IsLeapYear
{
    class CheckYear
    {
        static void Main(string[] args)
        {
            int year;

            do
            {
                Console.Write("Please enter a valid year: ");
                year = int.Parse(Console.ReadLine());
            } while (year < 0);

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("The year {0} is leap.", year);
            }
            else
            {
                Console.WriteLine("The year {0} is not leap.", year);
            }
            
        }
    }
}
