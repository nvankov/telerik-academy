using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NumberOfWorkdays
{
    public class NumberOfWorkdays
    {
        private static DateTime[] holidays = 
        {
            new DateTime(2013, 1, 1),   //New Year's Day
            new DateTime(2013, 1, 2),   //Day after New Year's Day
            new DateTime(2013, 3, 3),   //Liberation Day
            new DateTime(2013, 5, 24),  //Education and Culture, and Slavonic Literature Day
            new DateTime(2013, 9, 6),   //Unification Day
            new DateTime(2013, 12, 24), //Christmas Eve
            new DateTime(2013, 12, 25), //Christmas Day
            new DateTime(2013, 12, 26)  //Second Day of Christmas
        };

        private static void TrimStartAndEnd(ref DateTime start, ref DateTime end)
        {
            if (start.DayOfWeek == DayOfWeek.Saturday)
            {
                start = start.AddDays(2);
            }

            if (start.DayOfWeek == DayOfWeek.Sunday)
            {
                start = start.AddDays(1);
            }

            if (end.DayOfWeek == DayOfWeek.Saturday)
            {
                end = end.AddDays(-1);
            }

            if (end.DayOfWeek == DayOfWeek.Sunday)
            {
                end = end.AddDays(-2);
            }
        }

        private static int CalculateDays(DateTime start, DateTime end)
        {
            if (start > end)
            {
                DateTime temp = start;
                start = end;
                end = temp;
            }

            TrimStartAndEnd(ref start, ref end);
            int daysBetwenDates = (end - start).Days;
            DateTime date = start;
            int workdays = daysBetwenDates;

            for (int i = 0; i < daysBetwenDates; i++)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    workdays--;
                    date = date.AddDays(1);
                    continue;
                }

                foreach (var holiday in holidays)
                {
                    if (date.Day == holiday.Day && date.Month == holiday.Month)
                    {
                        workdays--;
                    }
                }

                date = date.AddDays(1);
            }

            return workdays;
        }
        
        public static void Main(string[] args)
        {
            int day;
            int month;
            int year;
            DateTime today = DateTime.Now;
            DateTime userDate;

            Console.Write("Please enter a day: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Please enter a month: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Please enter a year: ");
            year = int.Parse(Console.ReadLine());

            userDate = new DateTime(year, month, day);

            Console.WriteLine("Workdays between today and entered date: {0}", CalculateDays(today, userDate));
        }
    }
}
