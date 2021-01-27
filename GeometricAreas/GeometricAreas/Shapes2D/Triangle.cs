using System;
using System.Configuration;
using GeometricAreas.MathModels;
using static System.Math;

namespace GeometricAreas.Shapes2D
{
    public static class Triangle
    {
        private static double TOLERANCE = Double.Parse(ConfigurationManager.AppSettings["epsilon"]);
        
        public static double GaussArea(Point p1, Point p2, Point p3)
        {
            return Polygon.SimplePolygonGaussArea(p1, p2, p3);
        }

        public static double RegularTriangleArea(double a = 0, double R = 0, double r = 0)
        {
            return Polygon.RegularPolygonArea(3, a, R, r);
        }

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
            return Math.Abs(c * c - (a * a + b * b)) < TOLERANCE;
        }
        
        private static bool IsEquilateral(double a, double b, double c)
        {
            return Math.Abs(a - b) < TOLERANCE && Math.Abs(b - c) < TOLERANCE;
        }
    }
}