namespace Euclidian3DSpace.Utilities
{
    using System;

    public static class Point3DMethods
    {
        public static double GetDistance3D(Point3D first, Point3D second)
        {
            var distanceX = Math.Pow((second.X - first.X), 2);
            var distanceY = Math.Pow((second.Y - first.Y), 2);
            var distanceZ = Math.Pow((second.Z - first.Z), 2);

            var distance = Math.Sqrt(distanceX + distanceY + distanceZ);

            return distance;
        }
    }
}