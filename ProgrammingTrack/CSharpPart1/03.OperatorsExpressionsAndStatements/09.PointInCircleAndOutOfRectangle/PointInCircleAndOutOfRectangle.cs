using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PointInCircleAndOutOfRectangle
{
    class PointInCircleAndOutOfRectangle
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            bool isPointInCircle = false;
            bool isPointInRectangle = false;

            Console.Write("Enter value for x: ");
            x = Int32.Parse(Console.ReadLine());

            Console.Write("Enter value for y: ");
            y = Int32.Parse(Console.ReadLine());

            if (x * x + y * y <= 3)
            {
                isPointInCircle = true;
            }

            if (x > -1 && x < 5 && y > -1 && y < 1) //Ако едно от условията не е изпълнено то точката е извън правоъгълника
            {
                isPointInRectangle = true;
            }

            Console.WriteLine("The point {0} in the cicle", (isPointInCircle ? "is" : "is not"));
            Console.WriteLine("The point {0} in the rectangle", (isPointInRectangle ? "is" : "is not"));
        }
    }
}
