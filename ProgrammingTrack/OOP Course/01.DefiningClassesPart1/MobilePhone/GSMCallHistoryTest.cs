using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMCallHistoryTest
    {
        public static void AddCalls(GSM gsm)
        {
            Call[] callArray = new Call[3];
            callArray[0] = new Call(DateTime.Now, "0889123456", 5);
            callArray[1] = new Call(DateTime.Now, "0889123455", 12);
            callArray[2] = new Call(DateTime.Now, "0878536897", 3);

            for (int index = 0; index < callArray.Length; index++)
            {
                gsm.AddCall(callArray[index]);
            }
        }

        public static void DisplayCalls(GSM gsm)
        {
            foreach (var item in gsm.CallHistory)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static decimal CalculatePrice(GSM gsm, decimal price)
        {
            return gsm.CalculateTotalPrice(price);
        }

        public static void RemoveLongestCall(GSM gsm)
        {
            int index = 0;
            int bestIndex = 0;
            int longestCallDuration = int.MinValue;
            int currentCallDuration;

            foreach (var item in gsm.CallHistory)
            {
                currentCallDuration = item.Duration;

                if (currentCallDuration > longestCallDuration)
                {
                    longestCallDuration = currentCallDuration;
                    bestIndex = index;
                    break;
                }

                index++;
            }

            gsm.CallHistory.RemoveAt(bestIndex);
        }

        public static void TestCalls()
        {
            GSM gsm = new GSM("Galaxy S", "Samsung", 500, "Peter", 
                new Battery("GalaxyS Battery", 200, 30, BatteryType.LiIon), 
                new Display(4.0, 65000));

            decimal price = 0.37M;

            Console.WriteLine("Adding calls...");
            AddCalls(gsm);
            Console.WriteLine("Dislaying calls: ");
            Console.WriteLine();
            DisplayCalls(gsm);
            Console.WriteLine();
            Console.WriteLine("Total price of calls: {0}", CalculatePrice(gsm, price));
            RemoveLongestCall(gsm);
            Console.WriteLine("Price without the longest call: {0}", CalculatePrice(gsm, price));
            gsm.DeleteAllCalls();
            Console.WriteLine("Dislaying calls after removal: ");
            DisplayCalls(gsm);

        }
    }
}
