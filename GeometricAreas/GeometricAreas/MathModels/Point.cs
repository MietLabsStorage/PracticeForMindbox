using System.Collections.Generic;

namespace GeometricAreas.MathModels
{
    public class Point
    {
        public List<double> Coordinates { get; } = new List<double>();

        public Point(params double[] coordinates)
        {
            foreach (var coord in coordinates)
            {
                Coordinates.Add(coord);
            }
        }

        public Point(Point point)
        {
            foreach (var coord in point.Coordinates)
            {
                Coordinates.Add(coord);
            }
        }
    }
}