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
            foreach (Car car in this.cars)
            {
                CarToStringVisitor carToStringVisitor = new CarToStringVisitor();
                car.Accept(carToStringVisitor);
                Console.WriteLine(carToStringVisitor.GetCarDescription());
            }
        }
    }
}
