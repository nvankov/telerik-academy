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
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            Dictionary<int, int> occurances = new Dictionary<int, int>();
            int bestElement = array[0];
            int elementOccurances = int.MinValue;

            for (int index = 0; index < array.Length; index++)
            {
                //Ако ключ съдържа стойността да увеличи честотата на срещане
                if (occurances.ContainsKey(array[index]))
                {
                    occurances[array[index]]++;
                }
                else
                {
                    occurances.Add(array[index], 1);
                }
            }

            foreach (var item in occurances)
            {
                if (item.Value > elementOccurances)
                {
                    elementOccurances = item.Value;
                    bestElement = item.Key;
                }
            }

            Console.WriteLine("Most common element is: {0}", bestElement);
            Console.WriteLine("Occurances: {0}", elementOccurances);
        }
    }
}
