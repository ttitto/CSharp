namespace VisitorPatternAndEncapsulation.CarShop
{
    using System.Collections.Generic;
    using System.Linq;

    public class Car
    {
        private readonly string make;
        private readonly string model;
        private readonly Engine engine;
        private readonly IEnumerable<Seat> seats;

        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            this.make = make;
            this.model = model;
            this.engine = engine;
            this.seats = new List<Seat>(seats);
        }

        public CarRegistration Register()
        {
            return new CarRegistration(this.make.ToUpper(), this.model, this.engine.CylinderVolume, this.seats.Sum(seat => seat.Capacity));
        }

        public void Accept(ICarVisitor visitor)
        {
            visitor.VisitCar(this.make, this.model);
            this.engine.Accept(visitor);
            foreach (Seat seat in this.seats)
            {
                seat.Accept(visitor);
            }
        }
    }
}
