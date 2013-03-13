using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ExchangeSelectedBits
{
    class ExchangeSelectedBits
    {
        static void Main(string[] args)
        {
            uint number;
            int firstPosition;
            int secondPosition;
            int numberOfBits;
            uint temp;
            uint first;
            uint second;

            Console.Write("Enter a number: ");
            number = UInt32.Parse(Console.ReadLine());
            
            Console.Write("Enter the number of bits you want to swap: ");
            numberOfBits = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a starting position: ");
            firstPosition = Int32.Parse(Console.ReadLine());

            do
            {
                Console.Write("Enter a second starting position(must be bigger than {0}): ", (firstPosition + numberOfBits));
                secondPosition = Int32.Parse(Console.ReadLine());

            } while (secondPosition < firstPosition + numberOfBits);

            Console.WriteLine("Number before the transformation: {0}", Convert.ToString(number, 2));

            for (int i = 0; i < numberOfBits; i++)
            {
                //Получаваме стойността на първата позиция
                first = number & (uint)(1 << (firstPosition + i)); 
                first = first >> (firstPosition + i);

                //Получаваме стойността на втората позиция
                second = number & (uint)(1 << (secondPosition + i)); 
                second = second >> (secondPosition + i);

                //Зануляваме първата и втората позиция
                number = number & (uint)(~(1 << (firstPosition + i)));
                number = number & (uint)(~(1 << (secondPosition + i))); 

                //Разменяме стойностите на първата и втората позиция
                temp = first;
                first = second;
                second = temp;

                //Записваме новите стойностите в number
                number = number | (first << (firstPosition + i));
                number = number | (second << (secondPosition + i));

            }

            Console.WriteLine("Number after the transformation:  {0}", Convert.ToString(number, 2));


        }
    }
}
