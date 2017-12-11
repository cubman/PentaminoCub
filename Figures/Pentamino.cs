using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaminoCub.Figures
{
   
    public static class Pentamino
    {
        static public Func<Point3D, Cub, bool>[] functions = new Func<Point3D, Cub, bool>[] {
            position_F_3_B_2_U,
            position_F_3_B_2_B_L,
            position_F_3_B_2_B_R,
            position_R_3_B_2_U,
            position_R_3_B_2_B_L,
            position_R_3_B_2_B_R,
            position_B_3_B_2_U,
            position_B_3_B_2_B_L,
            position_B_3_B_2_B_R
        };
        // основание 3, верх 2, направлена от нас
        public static bool position_F_3_B_2_U(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(1, 4, 2)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(0, 1, 0))
                && cub.isFreePosition(point.movePoint(0, 2, 0)) && cub.isFreePosition(point.movePoint(0, 2, 1))
                && cub.isFreePosition(point.movePoint(0, 3, 1));
        }

        // основание 3, основание 2, направлена от нас ( на левом боку )
        public static bool position_F_3_B_2_B_L(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(2, 4, 1)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(0, 1, 0))
                && cub.isFreePosition(point.movePoint(0, 2, 0)) && cub.isFreePosition(point.movePoint(-1, 2, 0))
                && cub.isFreePosition(point.movePoint(-1, 3, 0));
        }

        // основание 3, основание 2, направлена от нас ( на правом боку )
        public static bool position_F_3_B_2_B_R(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(2, 4, 1)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(0, 1, 0))
                && cub.isFreePosition(point.movePoint(0, 2, 0)) && cub.isFreePosition(point.movePoint(1, 2, 0))
                && cub.isFreePosition(point.movePoint(1, 3, 0));
        }

        // ---------------------------------------
        // основание 3, верх 2, направлена вправо
        public static bool position_R_3_B_2_U(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(4, 1, 2)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(1, 0, 0))
                && cub.isFreePosition(point.movePoint(2, 0, 0)) && cub.isFreePosition(point.movePoint(2, 0, 1))
                && cub.isFreePosition(point.movePoint(3, 0, 1));
        }
     

        // основание 3, верх 2, направлена вправо ( на левом боку )
        public static bool position_R_3_B_2_B_L(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(4, 2, 1)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(0, 1, 0))
                && cub.isFreePosition(point.movePoint(0, 2, 0)) && cub.isFreePosition(point.movePoint(-1, 2, 0))
                && cub.isFreePosition(point.movePoint(-1, 3, 0));
        }


        // основание 3, основание 2, направлена вправо ( на правом боку )
        public static bool position_R_3_B_2_B_R(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(4, 2, 1)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(1, 0, 0))
                && cub.isFreePosition(point.movePoint(2, 0, 0)) && cub.isFreePosition(point.movePoint(2, -1, 0))
                && cub.isFreePosition(point.movePoint(3, -1, 0));
        }

        // ---------------------------------------
        //****************************************
  
        // основание 3, верх 2, направлена к нам
        public static bool position_B_3_B_2_U(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(1, 4, 2)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(0, -1, 0))
                && cub.isFreePosition(point.movePoint(0, -2, 0)) && cub.isFreePosition(point.movePoint(0, -2, 1))
                && cub.isFreePosition(point.movePoint(0, -3, 1));
        }

        // основание 3, основание 2, направлена к нам ( на левом боку )
        public static bool position_B_3_B_2_B_L(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(2, 4, 1)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(0, -1, 0))
                && cub.isFreePosition(point.movePoint(0, -2, 0)) && cub.isFreePosition(point.movePoint(-1, -2, 0))
                && cub.isFreePosition(point.movePoint(-1, -3, 0));
        }

        // основание 3, основание 2, направлена к нам ( на правом боку )
        public static bool position_B_3_B_2_B_R(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(2, 4, 1)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(0, -1, 0))
                && cub.isFreePosition(point.movePoint(0, -2, 0)) && cub.isFreePosition(point.movePoint(1, -2, 0))
                && cub.isFreePosition(point.movePoint(1, -3, 0));
        }

        // ***************************************
        // ---------------------------------------
        // основание 3, верх 2, направлена влево
        public static bool position_L_3_B_2_U(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(4, 1, 2)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(-1, 0, 0))
                && cub.isFreePosition(point.movePoint(-2, 0, 0)) && cub.isFreePosition(point.movePoint(-2, 0, 1))
                && cub.isFreePosition(point.movePoint(-3, 0, 1));
        }


        // основание 3, верх 2, направлена влево ( на левом боку )
        public static bool position_L_3_B_2_B_L(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(4, 2, 1)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(0, 1, 0))
                && cub.isFreePosition(point.movePoint(0, 2, 0)) && cub.isFreePosition(point.movePoint(-1, 2, 0))
                && cub.isFreePosition(point.movePoint(-1, 3, 0));
        }


        // основание 3, основание 2, направлена влево ( на правом боку )
        public static bool position_L_3_B_2_B_R(Point3D point, Cub cub)
        {
            if (!point.inCub(cub.size, new Point3D(4, 2, 1)))
                return false;

            return cub.isFreePosition(point.movePoint(0, 0, 0)) && cub.isFreePosition(point.movePoint(1, 0, 0))
                && cub.isFreePosition(point.movePoint(2, 0, 0)) && cub.isFreePosition(point.movePoint(2, -1, 0))
                && cub.isFreePosition(point.movePoint(3, -1, 0));
        }
    }
}
