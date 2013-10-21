using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AddsTwoNumbersAsArrays
{
    class AddsTwoNumbersAsArrays
    {
        static void CopyArray(int[] arrayToCopy, int[] arrayToFill)
        {
            for (int index = 0; index < arrayToCopy.Length; index++)
            {
                arrayToFill[index] = arrayToCopy[index];
            }
        }
        static int[] StringAsIntArray(string number)
        {
            char[] charArray = number.ToCharArray();
            int[] intArray = new int[charArray.Length];

            for (int index = 0; index < charArray.Length; index++)
            {
                intArray[index] = int.Parse((charArray[index]).ToString());
            }

            return intArray;
        }

        static int[] SumTwoNumbersAsArrays(int[] firstNumber, int[] secondNumber)
        {
            int arraySize = firstNumber.Length > secondNumber.Length ? firstNumber.Length : secondNumber.Length;
            int[] firstArray = new int[arraySize];
            int[] secondArray = new int[arraySize];
            
            int[] result = new int[10000];

            CopyArray(firstNumber, firstArray);
            CopyArray(secondNumber, secondArray);

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            for (int index = 0; index < firstArray.Length; index++)
            {
                //result[index] е равно на нула, но предишното събиране може да е добавило стойност, която иначе ще се загуби
                result[index] = result[index] + firstArray[index] + secondArray[index];

                //Ако събирането е дало резултат 10 или повече десетиците се пренасят към следващия елемент, 
                //а в текущият елемент се записват само стойността на единиците
                if (result[index] > 9)
                {
                    result[index] %= 10;
                    result[index + 1]++;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            string firstNumber = "123456";
            string secondNumber = "789456";

            //Console.Write("Please add a value for the first number: ");
            //firstNumber = Console.ReadLine();
            //Console.Write("Please add a value for the second number: ");
            //secondNumber = Console.ReadLine();

            int[] firstArray = StringAsIntArray(firstNumber);
            int[] secondArray = StringAsIntArray(secondNumber);

            int[] result = SumTwoNumbersAsArrays(firstArray, secondArray);
            Array.Reverse(result);
            

            Console.WriteLine("The resulting array is: ");
            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }
    }
}
