namespace Problems1to4.Geometry.Storage
{
    using System;
    using System.IO;
    using Problems1to4.Geometry.Geometry3D;

    public static class Storage
    {
        public static void ToFile(string filePath, Path3D path)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(path.ToString());
            }
        }

        public static Path3D FromFile(string filepath)
        {
            Path3D path = new Path3D();

            using (StreamReader reader = new StreamReader(filepath))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    double[] coords = Array.ConvertAll(line.Split('\t'), double.Parse);
                    path.Add(new Point3D(coords[0], coords[1], coords[2]));
                    line = reader.ReadLine();
                }
            }

            return path;
        }
    }
}
