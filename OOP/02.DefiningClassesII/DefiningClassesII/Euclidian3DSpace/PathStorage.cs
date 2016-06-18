namespace Euclidian3DSpace.Utilities
{
    using System.Text;
    using System.Linq;

    public static class PathStorage
    {
        public static void SavePath(Path path, string destination)
        {
            var writer = new System.IO.StreamWriter(destination, false, Encoding.UTF8);

            using (writer)
            {
                var points = path.GetPoints();

                foreach (var point in points)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            var path = new Path();

            var reader = new System.IO.StreamReader(filePath, Encoding.UTF8);

            string currentPoint;
            double[] coordinates;
            double x, y, z;

            using (reader)
            {
                while (true)
                {
                    currentPoint = reader.ReadLine();
                    if (currentPoint == null)
                    {
                        break;
                    }

                    currentPoint = currentPoint.Trim('(', ')');
                    coordinates = currentPoint.Split(',')
                        .Select(double.Parse)
                        .ToArray();

                    x = coordinates[0];
                    y = coordinates[1];
                    z = coordinates[2];

                    path.AddPoint(new Point3D(x, y, z));
                }
            }

            return path;
        }
    }
}