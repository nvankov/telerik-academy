using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintCurrentDayOfWeek
{
    class PrintCurrentDayOfWeek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today is: {0}", DateTime.Now.DayOfWeek);
        }
    }
}
