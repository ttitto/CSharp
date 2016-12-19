namespace VisitorPatternAndEncapsulation
{
    using System;
    using System.Collections.Generic;
    using CarShop;

    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<Car> cars = new CarRepository().GetAll();
            CarsView view = new CarsView(cars);
            view.Render();

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
