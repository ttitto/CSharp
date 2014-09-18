using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
   public static class DistanceCalculator
    {
        public static double CalculateDistance3D(Point3D firstPoint3D, Point3D secondPoint3D)
        {
            double distance = 0;
            distance = Math.Sqrt((firstPoint3D.X - secondPoint3D.X) * (firstPoint3D.X - secondPoint3D.X) +
                (firstPoint3D.Y - secondPoint3D.Y) * (firstPoint3D.Y - secondPoint3D.Y) +
                (firstPoint3D.Z - secondPoint3D.Z) * (firstPoint3D.Z - secondPoint3D.Z));
            return distance;
        }
    }
}
