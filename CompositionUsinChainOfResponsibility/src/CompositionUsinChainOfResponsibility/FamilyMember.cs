namespace CompositionUsinChainOfResponsibility
{
    using System.Collections.Generic;
    using Common;

    public class FamilyMember
    {
        private readonly ChainElement components;

        public FamilyMember(ChainElement components)
        {
            this.components = components;
        }

        public T As<T>(T defaultValue) where T : class
        {
            return this.components.As<T>(defaultValue);
        }
    }
}
