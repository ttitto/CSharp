namespace VisitorPatternAndEncapsulation.CarShop
{
    using System;

    public interface ICar
    {
        void Accept(Func<ICarVisitor> visitorFactory);
        T Accept<T>(Func<ICarVisitor<T>> visitorFactory);
        CarRegistration Register();
    }
}