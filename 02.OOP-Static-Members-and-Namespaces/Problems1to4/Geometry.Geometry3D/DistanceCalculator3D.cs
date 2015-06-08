namespace Problems1to4.Geometry.Geometry3D
{
    using System;

    public static class DistanceCalculator3D
    {
        public static double CalculateDistance3D(Point3D p1, Point3D p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2) + Math.Pow(p1.Z - p2.Z, 2));
        } 
    }
}
