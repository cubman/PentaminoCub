using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaminoCub.Figures
{
    public class Point3D
    {
        public int x { get; }
        public int y { get; }
        public int z { get; }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool inCub(int size, Point3D pentaSize)
        {
            int x = this.x + pentaSize.x;
            int y = this.y + pentaSize.y;
            int z = this.z + pentaSize.z;

            return (x >= 0) && (x < size) && (y >= 0) && (y < size) && (z >= 0) && (z < size);
        }

        public Point3D movePoint(int x, int y, int z)
        {
            return new Point3D(this.x + x, this.y + y, this.z + z);
        }
    }
}
