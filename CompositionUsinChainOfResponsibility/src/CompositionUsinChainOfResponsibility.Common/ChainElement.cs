namespace CompositionUsinChainOfResponsibility.Common
{
    public class ChainElement : IChainElement
    {
        private readonly IChainElement next;

        public ChainElement(IChainElement next)
        {
            this.next = next;
        }

        protected ChainElement()
            : this(NullChainElement.Instance) { }

        public virtual T As<T>(T defaultValue) where T : class
        {
            if (this is T)
            {
                return this as T;
            }

            return this.next.As<T>(defaultValue);
        }
    }
}
