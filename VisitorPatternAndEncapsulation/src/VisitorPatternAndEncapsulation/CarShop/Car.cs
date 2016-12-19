namespace VisitorPatternAndEncapsulation.CarShop
{
    using System.Collections.Generic;

    public class Car
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public Engine Engine { get; private set; }
        public IEnumerable<Seat> Seats { get; private set; }

        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            this.Make = make;
            this.Model = model;
            this.Engine = engine;
            this.Seats = new List<Seat>(seats);
        }
    }
}
