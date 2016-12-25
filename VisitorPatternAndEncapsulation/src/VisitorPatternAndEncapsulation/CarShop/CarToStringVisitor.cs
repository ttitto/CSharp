using System;

namespace VisitorPatternAndEncapsulation.CarShop
{
    public class CarToStringVisitor : ICarVisitor
    {
        private int seatCount;
        private string engineDetails;
        private string carDetails;

        public string GetCarDescription()
        {
            return $"{this.carDetails} {this.engineDetails} {this.seatCount} seat(s)";
        }

        public void VisitCar(string make, string model)
        {
            this.carDetails = $"{make} {model}";
        }

        public void VisitSeat(string name, int capacity)
        {
            this.seatCount += capacity;
        }

        public void VisitEngine(EngineStructure structure, EngineStatus status)
        {
            this.engineDetails += $"{structure.CylinderVolume}cc {structure.Power}kW";
        }
    }
}
