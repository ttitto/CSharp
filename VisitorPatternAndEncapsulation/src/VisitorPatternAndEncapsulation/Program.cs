namespace VisitorPatternAndEncapsulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarShop;

    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<Car> cars = new CarRepository().GetAll();
            //CarsView view = new CarsView(cars);
            //view.Render();

            //Car car = new Car("Renault", "Megane", new Engine(66, 1598), Seat.FourSeatConfiguration);
            //CarRegistration registration = car.Register();
            //Console.WriteLine(registration);

            //Car car = new CarRepository().GetAll().Last();
            //car.Accept(() => new SaveCarVisitor());

            //CarRegistration registration1 = new CarRegistration(car.make, car.model, car.Engine.CylinderVolume, car.seats.Sum(seat => seat.Capacity));
            //Console.WriteLine(registration1);

            foreach (var car in cars)
            {
                Console.WriteLine(car.Register());
            }

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
