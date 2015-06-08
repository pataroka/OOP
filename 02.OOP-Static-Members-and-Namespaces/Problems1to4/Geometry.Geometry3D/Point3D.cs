namespace Problems1to4.Geometry.Geometry3D
{
    public class Point3D
    {
        private static readonly Point3D StartingPoint3D = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;

        }

        public Point3D StartingPoint
        {
            get
            {
                return StartingPoint3D;
            }
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public double Z { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}", this.X, this.Y, this.Z);
        }
    }
}
