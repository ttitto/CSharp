namespace VisitorPatternAndEncapsulation.CarShop
{
    using System;
    using System.Collections.Generic;

    public class CarsView
    {
        private IEnumerable<Car> cars;

        public CarsView(IEnumerable<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }

        public void Render()
        {
            foreach (Car car in this.cars)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Engine.CylinderVolume}cc {car.Engine.Power}kW");
            }
        }
    }
}
