namespace CompositionUsinChainOfResponsibility
{
    using System.Collections.Generic;

    public class FamilyMember
    {
        private readonly IEnumerable<object> parts;

        public FamilyMember(IEnumerable<object> parts)
        {
            this.parts = new List<object>(parts);
        }

        public T As<T>()
        {
            foreach (object part in this.parts)
            {
                if (part is T)
                {
                    return (T)part;
                }
            }

            return default(T);
        }
    }
}
