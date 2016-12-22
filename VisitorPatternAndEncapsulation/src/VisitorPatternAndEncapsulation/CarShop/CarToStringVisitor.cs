using System;

namespace VisitorPatternAndEncapsulation.CarShop
{
    public class CarToStringVisitor : ICarVisitor
    {
        private string report;
        private int seatCount;

        public string GetCarDescription()
        {
            return this.report + $", {this.seatCount} seats";
        }

        public void VisitCar(string make, string model)
        {
            this.report += $"{make} {model}";
        }

        public void Visit(Seat seat)
        {
            this.seatCount += seat.Capacity;
        }

        public void Visit(Engine engine)
        {
            this.report += $"{engine.CylinderVolume}cc {engine.Power}kW";
        }
    }
}
