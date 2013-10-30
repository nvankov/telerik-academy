using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensions
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            dynamic sum = 0;
            foreach (var item in enumeration)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            dynamic sum = 1;
            foreach (var item in enumeration)
            {
                sum *= item;
            }

            return sum;
        }

        public static T Min<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            dynamic min = enumeration.First();

            foreach (var item in enumeration)
            {
                if (min > item)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            dynamic max = enumeration.First();

            foreach (var item in enumeration)
            {
                if (max < item)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            dynamic sum = 0;
            int count = 0;

            foreach (var item in enumeration)
            {
                sum += item;
                count++;
            }

            return sum / count;
        }
    }
}
