namespace VisitorPatternAndEncapsulation.CarShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CarPersistance
    {
        public int InsertCar(string make, string model)
        {
            Console.WriteLine("INSERT INTO CarShop.Car(Make, Model)\n" +
               "VALUES ('{0}', '{1}');\n" +
               "SELECT SCOPE_IDENTITY",
               make, model);

            int carId = new Random().Next(100);
            Console.WriteLine("CarId = {0}", carId);
            Console.WriteLine();

            return carId;
        }

        public void InsertEngine(int carId, float power, float cylinderVolume)
        {
            Console.WriteLine("INSERT INTO CarShop.Engine(CarId, Power, CylinderVolume)\n" +
               "VALUES({0}, {1}, {2})",
               carId, power, cylinderVolume);
            Console.WriteLine();
        }

        public void InsertSeat(int carId, string name, int capacity)
        {
            Console.WriteLine("INSERT INTO CarShop.Seat(CarId, Name, Capacity)\n" +
                "VALUES ({0}, {1}, {2})",
                carId, name, capacity);
            Console.WriteLine();
        }
    }
}
