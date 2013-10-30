using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinate
{
    public static class ThreeDimensionalSpace
    {
        static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            int x = firstPoint.X - secondPoint.X;
            int y = firstPoint.Y - secondPoint.Y;
            int z = firstPoint.Z - secondPoint.Z;

            return Math.Sqrt((x * x) + (y * y) + (z * z));
        }
    }
}
