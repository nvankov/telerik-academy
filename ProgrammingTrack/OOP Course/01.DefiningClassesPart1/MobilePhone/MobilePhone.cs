using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class MobilePhone
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling test methods.");
            Console.WriteLine();
            GSM[] GSMArray = GSMTest.CreateArray();

            Console.WriteLine("Displaying information: ");
            GSMTest.DisplayGMSInformation(GSMArray);

            Console.WriteLine("Displaying information about IPhone4S: ");
            GSMTest.DisplayIPhoneInformation();

            Console.WriteLine();
            GSMCallHistoryTest.TestCalls();
        }
    }
}
