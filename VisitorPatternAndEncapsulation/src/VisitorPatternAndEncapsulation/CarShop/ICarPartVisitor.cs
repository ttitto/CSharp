namespace VisitorPatternAndEncapsulation.CarShop
{
    public interface ICarPartVisitor
    {
        void Visit(Engine engine);
        void Visit(Seat seat);
    }
}
