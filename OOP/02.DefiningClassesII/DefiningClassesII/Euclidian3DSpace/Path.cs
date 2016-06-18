namespace Euclidian3DSpace
{
    using System.Collections.Generic;

    public class Path
    {
        private readonly List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public List<Point3D> GetPoints()
        {
            return new List<Point3D>(this.points);
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", this.points) + "]";
        }
    }
}