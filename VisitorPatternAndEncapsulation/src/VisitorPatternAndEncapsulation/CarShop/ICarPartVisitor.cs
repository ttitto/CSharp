namespace VisitorPatternAndEncapsulation.CarShop
{
    public interface ICarPartVisitor
    {
        void VisitEngine(float power, float cylinderVolume, float temperatureC);
        void VisitSeat(string name, int capacity);
    }
}
