namespace VisitorPatternAndEncapsulation.CarShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CarsView
    {
        private IEnumerable<Car> cars;

        public CarsView(IEnumerable<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }

        public void Render()
        {
            //foreach (Car car in this.cars)
            //{
            //    Console.WriteLine($"{car.make} {car.model} {car.Engine.CylinderVolume}cc {car.Engine.Power}kW seat(s) {car.seats.Sum(seat => seat.Capacity)}");
            //}
        }
    }
}
