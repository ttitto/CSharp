namespace VisitorPatternAndEncapsulation.CarShop
{
    public interface ICarVisitor : ICarPartVisitor
    {
        void VisitCar(string make, string model);
    }
}