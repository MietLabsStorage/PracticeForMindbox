using System;
using static System.Math;
namespace GeometricAreas.Shapes2D
{
    public static class Ellipse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">semi-major axe</param>
        /// <param name="b">semi-minor axe</param>
        /// <returns></returns>
        public static double Area(double a, double b)
        {
            return PI * a * b;
        }

        /// <summary>
        /// Ax^2+Bx+C=1
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public static double Area(double A, double B, double C)
        {
            return 2 * PI / Sqrt(4 * A * C - B * B);
        }
        
        //TODO:
        //public static double SegmentArea(...)
        
    }
}