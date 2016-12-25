namespace VisitorPatternAndEncapsulation.CarShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class SaveCarVisitor : ICarVisitor
    {
        private int carId;

        public void VisitCar(string make, string model)
        {
            Console.WriteLine("INSERT INTO CarShop.Car(Make, Model)\n" +
                "VALUES ('{0}', '{1}');\n" +
                "SELECT SCOPE_IDENTITY",
                make, model);

            this.carId = new Random().Next(100);
            Console.WriteLine("CarId = {0}", this.carId);
            Console.WriteLine();
        }

        public void VisitEngine(EngineStructure structure, EngineStatus status)
        {
            Console.WriteLine("INSERT INTO CarShop.Engine(CarId, Power, CylinderVolume)\n" +
                "VALUES({0}, {1}, {2})",
                this.carId, structure.Power, structure.CylinderVolume);
            Console.WriteLine();
        }

        public void VisitSeat(string name, int capacity)
        {
            Console.WriteLine("INSERT INTO CarShop.Seat(CarId, Name, Capacity)\n" +
                "VALUES ({0}, {1}, {2})",
                this.carId, name, capacity);
            Console.WriteLine();
        }
    }
}
