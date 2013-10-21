using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CheckForBiggerNeighbours
{
    public class CheckForBiggerNeighbours
    {
        public static bool CheckNeigbours(int[] array, int position)
        {
            if (position < array.Length && position >= 0)
            {
                if (position == 0) //ако елементът се намира на първа позиция
                {
                    if (array[position] > array[position + 1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (position == array.Length - 1) //ако елементът се намира на последната позиция на масива
                    {
                        if (array[position] > array[position - 1])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (array[position] > array[position + 1] && array[position] > array[position - 1])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 123, 5};
            bool result;
            int posistion = 4;

            Console.WriteLine("The element at position {0} is bigger than the ones around him: {1}", 
                posistion, CheckNeigbours(array, posistion));

            posistion = 0;

            Console.WriteLine("The element at position {0} is bigger than the ones around him: {1}",
                posistion, CheckNeigbours(array, posistion));
        }
    }
}
