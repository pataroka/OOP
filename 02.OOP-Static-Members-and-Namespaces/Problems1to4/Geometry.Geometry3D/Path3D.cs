namespace Problems1to4.Geometry.Geometry3D
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Path3D : IEnumerable<Point3D>
    {
        private readonly List<Point3D> pathList;

        public Path3D()
        {
            this.pathList = new List<Point3D>();
        }

        public Path3D(List<Point3D> point3DList)
        {
            this.pathList = point3DList;
        }

        public Point3D this[int index]
        {
            get
            {
                if (index >= 0 && index < this.pathList.Count)
                {
                    return this.pathList[index];
                }

                throw new IndexOutOfRangeException(string.Format("Index {0} is invalid!", index));
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(string.Format("Value {0} is invalid!", (Point3D)null));
                }

                if (index < 0 || index >= this.pathList.Count)
                {
                    throw new IndexOutOfRangeException(string.Format("Index {0} is invalid!", index));
                }
            }
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return ((IEnumerable<Point3D>)this.pathList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Format(string.Join("\n", this.pathList));
        }

        public void Add(Point3D p1)
        {
            this.pathList.Add(p1);
        }
    }
}