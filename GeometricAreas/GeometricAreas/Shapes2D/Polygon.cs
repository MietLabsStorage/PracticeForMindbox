using GeometricAreas.MathModels;
using static System.Math;
namespace GeometricAreas.Shapes2D
{
    public static class Polygon
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="points">array of points</param>
        /// <returns></returns>
        public static double SimplePolygonGaussArea(params Point[] points)
        {
            double area = new double();
            for (int i = 0; i < points.Length - 1; i++)
            {
                area += points[i].Coordinates[0] * points[i + 1].Coordinates[1];
                area -= points[i + 1].Coordinates[0] * points[i].Coordinates[1];
            }
            return 0.5 * Abs(area);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">count of edges</param>
        /// <param name="a">length of edge</param>
        /// <param name="R">circumscribed radius</param>
        /// <param name="r">inscribed radius</param>
        /// <returns></returns>
        public static double RegularPolygonArea(int n, double a = 0, double R = 0, double r = 0)
        {
            if (a != 0)
            {
                return 0.25 * n * a * a / Tan(PI / n);
            }
            if (R != 0)
            {
                return 0.5 * n * R * R * Sin(PI / n);
            }
            if (r != 0)
            {
                return n * r * r * Tan(PI / n);
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">count of inside points</param>
        /// <param name="b">count of bound points</param>
        /// <returns></returns>
        public static double PickArea(int i, int b)
        {
            return i + b / (double)2 - 1;
        }
    }
}