using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinate
{
    struct Point3D
    {
        private static Point3D start = new Point3D(0, 0, 0);
        public static Point3D Start { get { return start; } }
        public int X { get; set;}
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return String.Format("Point: X = {0}, Y = {1}, Z = {2}", X, Y, Z);
        }
    }
}
