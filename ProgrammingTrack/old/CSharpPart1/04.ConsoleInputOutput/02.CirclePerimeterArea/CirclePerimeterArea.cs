using System;
using System.Threading;
using System.Globalization;

namespace _02.CirclePerimeterArea
{
    class CirclePerimeterArea
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double radius;
            double area;
            double perimeter;

            Console.Write("Enter a value for the raduis: ");
            radius = double.Parse(Console.ReadLine());

            perimeter = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;

            Console.WriteLine("A circle with radius of: {0} has a perimeter of: {1:0.000} and an area of: {2:0.000}", radius, perimeter, area);
        }
    }
}
