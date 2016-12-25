namespace VisitorPatternAndEncapsulation.CarShop
{
    public interface ICarPartVisitor
    {
        void VisitEngine(EngineStructure structure, EngineStatus status);
        void VisitSeat(string name, int capacity);
    }
}
