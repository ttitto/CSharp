using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    class PathsClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Point3D.StartingPoint.ToString());

            Point3D rectA = new Point3D("A", 1.2, 3, 5.6);
            Point3D rectB = new Point3D("B", -1.2, 3, 5.6);
            Point3D rectC = new Point3D("C", 1.2, -3, 5.6);
            Point3D rectD = new Point3D("D", 1.2, 3, -5.6);

            Path3D path = new Path3D(rectA, rectB, rectC, rectD);
            Console.WriteLine(path.ToString());

            //for (int i = 0; i < path.Count; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}

            Console.WriteLine(DistanceCalculator.CalculateDistance3D(rectA, rectD));

            //Storage tests
            Storage.SavePath(@"../../user_files/SavedPaths.txt",false, path);
            Storage.SavePath(@"../../user_files/SavedPaths.txt", true, path);

         var loadedList=   Storage.LoadPaths(@"../../user_files/SavedPaths.txt");
         loadedList.ForEach(p=>Console.WriteLine(p.ToString()));

        }
    }
}
