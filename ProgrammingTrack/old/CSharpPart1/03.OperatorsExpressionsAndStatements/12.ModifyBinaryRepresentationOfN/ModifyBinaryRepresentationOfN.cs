using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ModifyBinaryRepresentationOfN
{
    class ModifyBinaryRepresentationOfN
    {
        static void Main(string[] args)
        {
            int number;
            ushort position;
            ushort value;

            Console.Write("Enter value for the number: ");
            number = Int32.Parse(Console.ReadLine());
            Console.Write("Enter value for the position: ");
            position = Byte.Parse(Console.ReadLine());
            Console.Write("Enter the value in the position(0 or 1): ");
            value = Byte.Parse(Console.ReadLine());

            if (value == 1)
            {
                number = number | (value << position);
            }
            else
            {
                value = 1;

                int mask = value << position;
                mask = ~mask;

                number = number & mask;
            }

            Console.WriteLine("The number after the modification is {0}", number);
            
        }
    }
}
