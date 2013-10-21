using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 1, 1, 4, 2, 3, 4, 1, 2, 4, 9, 3 };
            Dictionary<int, int> occurances = new Dictionary<int, int>();
            int bestElement = 0;
            int frequency = int.MinValue;

            for (int index = 0; index < array.Length; index++)
            {
                if (occurances.ContainsKey(array[index])) //ако се съдържа ключа да се увеличи стойността
                {
                    occurances[array[index]]++;
                }

                //int tempValue;
                //if (occurances.TryGetValue(array[index], out tempValue))
                //{
                //    occurances[array[index]] = tempValue + 1;
                //}

                else
                {
                    occurances.Add(array[index], 1);
                }
            }

            foreach (var item in occurances)
            {
                if (item.Value > frequency)
                {
                    bestElement = item.Key;
                    frequency = item.Value;
                }
            }

            Console.WriteLine("Most common element is {0} with {1} occurances.", bestElement, frequency);
        }
    }
}
