using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    public class Path3D
    {

        private IList<Point3D> paths;

        public Path3D(params Point3D[] points3D)
        {
            this.Paths = points3D.ToList();
        }

        public IList<Point3D> Paths
        {
            get { return this.paths; }
            set
            {
                if (null == value) throw new ArgumentNullException();
                this.paths = value;
            }

        }

        public int Count
        {
            get { return this.Paths.Count; }
        }

        public Point3D this[int index]
        {
            get { return this.Paths[index]; }
            set
            {
                if (null == value) throw new ArgumentNullException();
                this.Paths[index] = value;
            }
        }
        public void Add(Point3D point)
        {
            this.Paths.Add(point);
        }
        public override string ToString()
        {
            StringBuilder pathsSB = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                pathsSB.Append(this[i].ToString());
                if (i != this.Count - 1) { pathsSB.Append(", "); }
            }
            return pathsSB.ToString();
        }


    }
}
