using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.IsYearLeap
{
    class IsYearLeap
    {
        static void Main(string[] args)
        {
            int yearToCheck;

            Console.Write("Enter a year: ");
            yearToCheck = int.Parse(Console.ReadLine());

            Console.WriteLine("Checking if the entered year is leap: {0}", DateTime.IsLeapYear(yearToCheck));
        }
    }
}
