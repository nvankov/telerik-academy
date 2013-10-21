using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ConcatenateTwoStrings
{
    class ConcatenateTwoStrings
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            object obj = firstString + " " + secondString;
            
            Console.WriteLine(obj);

            string thirdString = obj.ToString(); //Or string thirdString = (string)obj;

            Console.WriteLine(thirdString);
        }
    }
}
