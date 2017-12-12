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
            return (pentaSize.x >= 0) && (pentaSize.x < size) 
                && (pentaSize.y >= 0) && (pentaSize.y < size) && (pentaSize.z >= 0) && (pentaSize.z < size);
        }

        public Point3D movePoint(int x, int y, int z)
        {
            return new Point3D(this.x + x, this.y + y, this.z + z);
        }
    }
}
