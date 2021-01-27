namespace GeometricAreas.Shapes2D
{
    public static class Circle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="r">radius</param>
        /// <returns></returns>
        public static double Area(double r)
        {
            return Ellipse.Area(r, r);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r">radius</param>
        /// <param name="angle">radian angle</param>
        /// <returns></returns>
        public static double SegmentArea(double r, double angle)
        {
            return angle * r * r / 2;
        }
    }
}