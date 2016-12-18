namespace CompositionUsinChainOfResponsibility.Common
{
    public interface IChainElement
    {
        T As<T>(T defaultValue) where T : class;
    }
}
