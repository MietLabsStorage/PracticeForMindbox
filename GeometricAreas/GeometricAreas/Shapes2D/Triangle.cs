using System;
using System.Configuration;
using GeometricAreas.MathModels;
using static System.Math;

namespace GeometricAreas.Shapes2D
{
    public static class Triangle
    {
        private static readonly double Epsilon = Double.Parse(ConfigurationManager.AppSettings["epsilon"]);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1">point A</param>
        /// <param name="p2">point B</param>
        /// <param name="p3">point C</param>
        /// <returns></returns>
        public static double GaussArea(Point p1, Point p2, Point p3)
        {
            return Polygon.SimplePolygonGaussArea(p1, p2, p3);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">length of edge</param>
        /// <param name="R">circumscribed radius</param>
        /// <param name="r">inscribed radius</param>
        /// <returns></returns>
        public static double RegularTriangleArea(double a = 0, double R = 0, double r = 0)
        {
            return Polygon.RegularPolygonArea(3, a, R, r);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">edge a</param>
        /// <param name="b">edge b</param>
        /// <param name="c">edge c</param>
        /// <returns></returns>
        public static double Area(double a, double b, double c)
        {
            if (IsRight(a, b, c))
            {
                return 0.5 * a * b;
            }
            if(IsEquilateral(a,b,c))
            {
                return a * a * Sqrt(3) * 0.25;
            }
            double p = 0.5 * (a + b + c);
            return Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        
        private static bool IsRight(double a, double b, double c)
        {
            return Math.Abs(c * c - (a * a + b * b)) < Epsilon;
        }
        
        private static bool IsEquilateral(double a, double b, double c)
        {
            return Math.Abs(a - b) < Epsilon && Math.Abs(b - c) < Epsilon;
        }
    }
}