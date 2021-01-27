using System.Collections.Generic;

namespace GeometricAreas.MathModels
{
    public class Line
    {
        public Point Point1 { get; private set; }
        public Point Point2 { get; private set; }

        public Line(Point point1, Point point2)
        {
            Point1 = new Point(point1);
            Point2 = new Point(point2);
        }
    }
}