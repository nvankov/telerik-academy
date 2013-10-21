using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ExchangeBits
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {
            uint number = 1234567890;
            int[] array = new int[32];

            Console.WriteLine(Convert.ToString(number, 2));

            //Получавам стойностите на битовете
            array[3] = (int)number & (1 << 3);
            array[3] = array[3] >> 3;
            Console.WriteLine(array[3]);
            array[4] = (int)number & (1 << 4);
            array[4] = array[4] >> 4;
            Console.WriteLine(array[4]);
            array[5] = (int)number & (1 << 5);
            array[5] = array[5] >> 5;
            Console.WriteLine(array[5]);

            array[24] = (int)number & (1 << 24);
            array[24] = array[24] >> 24;
            Console.WriteLine(array[24]);
            array[25] = (int)number & (1 << 25);
            array[25] = array[25] >> 25;
            Console.WriteLine(array[25]);
            array[26] = (int)number & (1 << 26);
            array[26] = array[26] >> 26;
            Console.WriteLine(array[26]);

            //Разменям стойностите на битовете
            int temp;
            temp = array[3];
            array[3] = array[24];
            array[24] = temp;

            temp = array[4];
            array[4] = array[25];
            array[25] = temp;

            temp = array[5];
            array[5] = array[26];
            array[26] = temp;

            //Слагам стойността на новият бит на мястото на старият (т.е. стойността от бит 3 отива на 3 позиция и т.н.)
            Console.WriteLine("The original number is: {0}", number);
            Console.WriteLine("In binary: " + Convert.ToString(number, 2));
            
            uint newNumber = 1 << 3;
            newNumber = ~newNumber;
            number = number & newNumber;
            number = (number | (uint)(array[3] << 3));

            newNumber = 1 << 4;
            newNumber = ~newNumber;
            number = number & newNumber;
            number = (number | (uint)(array[4] << 4));

            newNumber = 1 << 5;
            newNumber = ~newNumber;
            number = number & newNumber;
            number = (number | (uint)(array[5] << 5));

            newNumber = 1 << 24;
            newNumber = ~newNumber;
            number = number & newNumber;
            number = (number | (uint)(array[24] << 24));

            newNumber = 1 << 25;
            newNumber = ~newNumber;
            number = number & newNumber;
            number = (number | (uint)(array[25] << 25));

            newNumber = 1 << 26;
            newNumber = ~newNumber;
            number = number & newNumber;
            number = (number | (uint)(array[26] << 26));

            Console.WriteLine("New number is: {0}", number);
            Console.WriteLine("In binary: " + Convert.ToString(number, 2));

        }
    }
}
