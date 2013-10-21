using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintName
{
    class PrintName
    {
        static void Main(string[] args)
        {
            string userName;

            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", userName);
        }
    }
}
