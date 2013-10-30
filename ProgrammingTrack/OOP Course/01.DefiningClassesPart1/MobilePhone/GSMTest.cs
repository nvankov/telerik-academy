using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMTest
    {
        public static GSM[] CreateArray()
        { 
            GSM[] array = new GSM[5];
            Battery[] batteries = new Battery[5];
            Display[] displays = new Display[5];

            //Batteries
            batteries[0] = new Battery("Unknown", 0, 0, BatteryType.LiIon);
            batteries[1] = new Battery("GalaxyS Battery", 200, 30, BatteryType.LiIon);
            batteries[2] = new Battery("Lumia Battery", 200, 30, BatteryType.LiIon);
            batteries[3] = new Battery("Dell", 200, 30, BatteryType.LiIon);
            batteries[4] = new Battery("GalaxyS", 30, 3, BatteryType.LiIon);

            //Displays
            displays[0] = new Display(4.0, 65000);
            displays[1] = new Display(4.0, 65000);
            displays[2] = new Display(4.0, 65000);
            displays[3] = new Display(4.0, 65000);
            displays[4] = new Display(4.0, 65000);

            //GSMs
            array[0] = new GSM("Unknown", "Unknown", 300, null, batteries[0], displays[0]);
            array[1] = new GSM("Galaxy S", "Samsung", 500, "Peter", batteries[1], displays[1]);
            array[2] = new GSM("Lumia 920", "Nokia", 500, "Ivan", batteries[2], displays[2]);
            array[3] = new GSM("Dell GSM", "Dell", 300, null, batteries[3], displays[3]);
            array[4] = new GSM("Galaxy S2", "Samsung", 300, "Joro", batteries[4], displays[4]);

            return array;
        }

        public static void DisplayGMSInformation(GSM[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine("Information about GSM {0}:", item.Model);
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }

        public static void DisplayIPhoneInformation()
        {
            Console.WriteLine(GSM.IPhone4s);
        }
    }
}
