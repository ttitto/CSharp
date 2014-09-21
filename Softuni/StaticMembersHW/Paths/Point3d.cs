using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Space3D
{
    public class Point3D
    {
        private string name;
        private double x;
        private double y;
        private double z;

        private static readonly Point3D startingPoint;

        static Point3D()
        {
            startingPoint = new Point3D("Center", 0, 0, 0);
        }
        public Point3D(string name, double x, double y, double z)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid 3D point name!");
                this.name = value;
            }
        }
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }
        public static Point3D StartingPoint
        {
            get { return Point3D.startingPoint; }
        }

        public override string ToString()
        {
            return String.Format("{3}{{ {0:F},{1:F},{2:F} }}", this.X.ToString(), this.Y.ToString(), this.Z.ToString(), this.Name);
        }

        public static Point3D DeSerialize(string pointStr){
            Regex rgx = new Regex(@"(.+?){(.+?),(.+?),(.+?)}");
            MatchCollection matches = rgx.Matches(pointStr);
                var g = (matches[0] as Match).Groups ;
                Point3D point = new Point3D(g[1].Value, double.Parse(g[2].Value), double.Parse(g[3].Value), double.Parse(g[4].Value));

                return point;
        }
    }
}
