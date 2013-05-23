using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NumberOfWorkdays
{
    class NumberOfWorkdays
    {
        static void Main(string[] args)
        {
            string userInput;
            string[] endDate;

            Console.Write("Enter an end date in the format dd/mm/yyyy: ");
            userInput = Console.ReadLine();

            endDate = userInput.Split('/');
            int day = int.Parse(endDate[2]);
            int month = int.Parse(endDate[1]);
            int year = int.Parse(endDate[0]);

            DateTime startDay = DateTime.Today;
            DateTime endDay = new DateTime(year, month, day);
            int timeLen = 0;
            timeLen = Math.Abs((endDay - startDay).Days);
            if (startDay > endDay)
            {
                startDay = endDay;
                endDay = DateTime.Today;
            }

            // Holydays
            DateTime[] holidays =
        {
            new DateTime(2013, 1, 1),
            new DateTime(2012, 2, 2),
            new DateTime(2012, 3, 3),
            new DateTime(2012, 4, 4),
            new DateTime(2013, 1, 18)
        };
            Console.WriteLine(timeLen);
            int workDayCounter = 0;
            bool isHoliday = false;

            // Day checker
            for (int i = 0; i < timeLen; i++)
            {
                startDay = startDay.AddDays(1);
                if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
                {
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (startDay == holidays[j])
                        {
                            isHoliday = true;
                            break;
                        }
                    }

                    if (!isHoliday)
                    {
                        workDayCounter++;
                    }

                    isHoliday = false;
                }
            }

            Console.WriteLine(workDayCounter);
        }
    }
}
