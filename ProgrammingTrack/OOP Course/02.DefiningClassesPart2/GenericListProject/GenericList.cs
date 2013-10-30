using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListProject
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct |
        AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : System.Attribute
    {
        public string Version { get; private set; }

        public VersionAttribute(int majorVersion, int minorVersion)
        {
            Version = String.Format("{0}.{1}", majorVersion, minorVersion);
        }
    }

    [Version(2, 13)]
    class GenericList<T> where T : IComparable
    {
        const int DefaultCapacity = 16;

        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        public GenericList()
            : this(DefaultCapacity)
        {
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                if (count >= elements.Length)
                {
                    T[] temp = new T[count * 2];
                    Array.Copy(elements, temp, elements.Length);
                    elements = temp;
                }
            }
        }

        public void Add(T element)
        {
            this.elements[count] = element;
            count++;
        }

        public void Remove(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("The element's index cannot be zere or bigger than the lenght.");
            }
            T[] temp = new T[Count];
            Array.Copy(elements, temp, index);
            Array.Copy(elements, index + 1, temp, index, elements.Length - (index + 1));
            elements = temp;
        }

        public void InsertAt(T element, int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("The element's index cannot be zere or bigger than the lenght.");
            }
            T[] temp = new T[Count];
            Array.Copy(elements, temp, index);
            temp[index] = element;
            Array.Copy(elements, index + 1, temp, index + 1, elements.Length - (index + 1));


        }

        public T Min()
        {
            T min = elements.Min();

            return min;
        }

        public T Max()
        {
            T max = elements.Max();

            return max;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        public override string ToString()
        {
            StringBuilder returnedString = new StringBuilder(); ;

            foreach (var item in elements)
            {
                returnedString.Append((String.Format("{0} \n", item)));
            }

            return returnedString.ToString();
        }
    }
}
