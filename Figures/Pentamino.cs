using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaminoCub.Figures
{
   
    public class Pentamino
    {
        static public Func<Point3D, Cub, Tuple<bool, Point3D[]>>[] functions = new Func<Point3D, Cub, Tuple<bool, Point3D[]>>[] {
            // основание 3
            position_F_3_B_2_U,
            position_F_3_B_2_B_L,
            position_F_3_B_2_B_R,
            position_R_3_B_2_U,
            position_R_3_B_2_B_L,
            position_R_3_B_2_B_R,
            position_B_3_B_2_U,
            position_B_3_B_2_B_L,
            position_B_3_B_2_B_R,
            position_L_3_B_2_U,
            position_L_3_B_2_B_L,
            position_L_3_B_2_B_R,
            // основаие 2
            position_F_2_B_3_U,
            position_F_2_B_3_B_L,
            position_F_2_B_3_B_R,
            position_R_2_B_3_U,
            position_R_2_B_3_B_L,
            position_R_2_B_3_B_R,
            position_B_2_B_3_U,
            position_B_2_B_3_B_L,
            position_B_2_B_3_B_R,
            position_L_2_B_3_U,
            position_L_2_B_3_B_L,
            position_L_2_B_3_B_R,
            // снование 3, вертикально
            position_F_3_2_U,
            position_F_3_2_R,
            position_F_3_2_B,
            position_F_3_2_L,
            // снование 2, вертикально
            position_F_2_3_U,
            position_F_2_3_R,
            position_F_2_3_B,
            position_F_2_3_L
        };

        private static bool canBeAccess(Point3D point, Cub cub, Point3D[] points)
        {
            if (!point.inCub(cub.size, points.Last()))
                return false;

            foreach (var p in points)
                if (!cub.isFreePosition(p))
                    return false;

            return true;
        }

        // основание 3, верх 2, направлена от нас
        public static Tuple<bool, Point3D[]> position_F_3_B_2_U(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 1, 0),
                point.movePoint(0, 2, 0),
                point.movePoint(0, 2, 1),
                point.movePoint(0, 3, 1)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 3, основание 2, направлена от нас ( на левом боку )
        public static Tuple<bool, Point3D[]> position_F_3_B_2_B_L(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 1, 0),
                point.movePoint(0, 2, 0),
                point.movePoint(-1, 2, 0),
                point.movePoint(-1, 3, 0)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 3, основание 2, направлена от нас ( на правом боку )
        public static Tuple<bool, Point3D[]> position_F_3_B_2_B_R(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 1, 0),
                point.movePoint(0, 2, 0),
                point.movePoint(1, 2, 0),
                point.movePoint(1, 3, 0)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // ---------------------------------------
        // основание 3, верх 2, направлена вправо
        public static Tuple<bool, Point3D[]> position_R_3_B_2_U(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(1, 0, 0),
                point.movePoint(2, 0, 0),
                point.movePoint(2, 0, 1),
                point.movePoint(3, 0, 1)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }
     

        // основание 3, верх 2, направлена вправо ( на левом боку )
        public static Tuple<bool, Point3D[]> position_R_3_B_2_B_L(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(1, 0, 0),
                point.movePoint(2, 0, 0),
                point.movePoint(2, 1, 0),
                point.movePoint(3, 1, 0)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }


        // основание 3, основание 2, направлена вправо ( на правом боку )
        public static Tuple<bool, Point3D[]> position_R_3_B_2_B_R(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(1, 0, 0),
                point.movePoint(2, 0, 0),
                point.movePoint(2, -1, 0),
                point.movePoint(3, -1, 0)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // ---------------------------------------
        //****************************************
  
        // основание 3, верх 2, направлена к нам
        public static Tuple<bool, Point3D[]> position_B_3_B_2_U(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, -1, 0),
                point.movePoint(0, -2, 0),
                point.movePoint(0, -2, 1),
                point.movePoint(0, -3, 1)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 3, основание 2, направлена к нам ( на левом боку )
        public static Tuple<bool, Point3D[]> position_B_3_B_2_B_L(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, -1, 0),
                point.movePoint(0, -2, 0),
                point.movePoint(-1, -2, 0),
                point.movePoint(-1, -3, 0)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 3, основание 2, направлена к нам ( на правом боку )
        public static Tuple<bool, Point3D[]> position_B_3_B_2_B_R(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, -1, 0),
                point.movePoint(0, -2, 0),
                point.movePoint(1, -2, 0),
                point.movePoint(1, -3, 0)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // ***************************************
        // ---------------------------------------
        // основание 3, верх 2, направлена влево
        public static Tuple<bool, Point3D[]> position_L_3_B_2_U(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(-1, 0, 0),
                point.movePoint(-2, 0, 0),
                point.movePoint(-2, 0, 1),
                point.movePoint(-3, 0, 1)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }


        // основание 3, верх 2, направлена влево ( на левом боку )
        public static Tuple<bool, Point3D[]> position_L_3_B_2_B_L(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(-1, 0, 0),
                point.movePoint(-2, 0, 0),
                point.movePoint(-2, 1, 0),
                point.movePoint(-3, 1, 0)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }


        // основание 3, основание 2, направлена влево ( на правом боку )
        public static Tuple<bool, Point3D[]> position_L_3_B_2_B_R(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(-1, 0, 0),
                point.movePoint(-2, 0, 0),
                point.movePoint(-2, -1, 0),
                point.movePoint(-3, -1, 0)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }


        /////////////// Основание 2
        // основание 2, верх 3, направлена от нас
        public static Tuple<bool, Point3D[]> position_F_2_B_3_U(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 1, 0),
                point.movePoint(0, 1, 1),
                point.movePoint(0, 2, 1),
                point.movePoint(0, 3, 1)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 2, основание 3, направлена от нас ( на левом боку )
        public static Tuple<bool, Point3D[]> position_F_2_B_3_B_L(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 1, 0),
                point.movePoint(-1, 1, 0),
                point.movePoint(-1, 2, 0),
                point.movePoint(-1, 3, 0)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 2, основание 3, направлена от нас ( на правом боку )
        public static Tuple<bool, Point3D[]> position_F_2_B_3_B_R(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 1, 0),
                point.movePoint(1, 1, 0),
                point.movePoint(1, 2, 0),
                point.movePoint(1, 3, 0)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // ---------------------------------------
        // основание 2, верх 3, направлена вправо
        public static Tuple<bool, Point3D[]> position_R_2_B_3_U(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(1, 0, 0),
                point.movePoint(1, 0, 1),
                point.movePoint(2, 0, 1),
                point.movePoint(3, 0, 1)};

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }


        // основание 2, верх 3, направлена вправо ( на левом боку )
        public static Tuple<bool, Point3D[]> position_R_2_B_3_B_L(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(1, 0, 0),
                point.movePoint(1, 1, 0),
                point.movePoint(2, 1, 0),
                point.movePoint(3, 1, 0) } ;

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }


        // основание 2, основание 3, направлена вправо ( на правом боку )
        public static Tuple<bool, Point3D[]> position_R_2_B_3_B_R(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(1, 0, 0),
                point.movePoint(1, -1, 0),
                point.movePoint(2, -1, 0),
                point.movePoint(3, -1, 0) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // ---------------------------------------
        //****************************************

        // основание 2, верх 3, направлена к нам
        public static Tuple<bool, Point3D[]> position_B_2_B_3_U(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, -1, 0),
                point.movePoint(0, -1, 1),
                point.movePoint(0, -2, 1),
                point.movePoint(0, -3, 1) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 2, основание 3, направлена к нам ( на левом боку )
        public static Tuple<bool, Point3D[]> position_B_2_B_3_B_L(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, -1, 0),
                point.movePoint(-1, -1, 0),
                point.movePoint(-1, -2, 0),
                point.movePoint(-1, -3, 0) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 2, основание 3, направлена к нам ( на правом боку )
        public static Tuple<bool, Point3D[]> position_B_2_B_3_B_R(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, -1, 0),
                point.movePoint(1, -1, 0),
                point.movePoint(1, -2, 0),
                point.movePoint(1, -3, 0) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // ***************************************
        // ---------------------------------------
        // основание 2, верх 3, направлена влево
        public static Tuple<bool, Point3D[]> position_L_2_B_3_U(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(-1, 0, 0),
                point.movePoint(-1, 0, 1),
                point.movePoint(-2, 0, 1),
                point.movePoint(-3, 0, 1) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }


        // основание 2, верх 3, направлена влево ( на левом боку )
        public static Tuple<bool, Point3D[]> position_L_2_B_3_B_L(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(-1, 0, 0),
                point.movePoint(-1, -1, 0),
                point.movePoint(-2, -1, 0),
                point.movePoint(-3, -1, 0) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }


        // основание 2, основание 3, направлена влево ( на правом боку )
        public static Tuple<bool, Point3D[]> position_L_2_B_3_B_R(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(-1, 0, 0),
                point.movePoint(-1, 1, 0),
                point.movePoint(-2, 1, 0),
                point.movePoint(-3, 1, 0) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        ////////////////// основание 3 направленное вверх
        // основание 3, направлена от нас
        public static Tuple<bool, Point3D[]> position_F_3_2_U(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 0, 1),
                point.movePoint(0, 0, 2),
                point.movePoint(0, 1, 2),
                point.movePoint(0, 1, 3) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 3, вправо
        public static Tuple<bool, Point3D[]> position_F_3_2_R(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 0, 1),
                point.movePoint(0, 0, 2),
                point.movePoint(1, 0, 2),
                point.movePoint(1, 0, 3) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 3, к нам
        public static Tuple<bool, Point3D[]> position_F_3_2_B(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 0, 1),
                point.movePoint(0, 0, 2),
                point.movePoint(0, -1, 2),
                point.movePoint(0, -1, 3) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 3, влево
        public static Tuple<bool, Point3D[]> position_F_3_2_L(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 0, 1),
                point.movePoint(0, 0, 2),
                point.movePoint(-1, 0, 2),
                point.movePoint(-1, 0, 3) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        ////////////////// основание 2 направленное вверх
        // основание 2, направлена от нас
        public static Tuple<bool, Point3D[]> position_F_2_3_U(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 0, 1),
                point.movePoint(0, 1, 1),
                point.movePoint(0, 1, 2),
                point.movePoint(0, 1, 3) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 2, вправо
        public static Tuple<bool, Point3D[]> position_F_2_3_R(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 0, 1),
                point.movePoint(1, 0, 1),
                point.movePoint(1, 0, 2),
                point.movePoint(1, 0, 3) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 2, к нам
        public static Tuple<bool, Point3D[]> position_F_2_3_B(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 0, 1),
                point.movePoint(0, -1, 1),
                point.movePoint(0, -1, 2),
                point.movePoint(0, -1, 3) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        // основание 2, влево
        public static Tuple<bool, Point3D[]> position_F_2_3_L(Point3D point, Cub cub)
        {
            Point3D[] points = new Point3D[] {
                point.movePoint(0, 0, 0),
                point.movePoint(0, 0, 1),
                point.movePoint(-1, 0, 1),
                point.movePoint(-1, 0, 2),
                point.movePoint(-1, 0, 3) };

            return new Tuple<bool, Point3D[]>(canBeAccess(point, cub, points), points);
        }

        public int pentaminoNumber { get; }

        public Pentamino(int num)
        {
            if (num == 0)
                throw new Exception();

            pentaminoNumber = num;
        }
    }
}
