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
        /// Ax^2+Bxy+Cy^2=1
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public static double Area(double A, double B, double C)
        {
            try
            {
                return 2 * PI / Sqrt(4 * A * C - B * B);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        
        //TODO:
        //public static double SegmentArea(...)
        
    }
}