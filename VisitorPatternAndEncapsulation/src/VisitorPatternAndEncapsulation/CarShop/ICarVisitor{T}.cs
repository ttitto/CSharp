namespace VisitorPatternAndEncapsulation.CarShop
{
    public interface ICarVisitor<T> : ICarVisitor
    {
        T ProduceResult();
    }
}
