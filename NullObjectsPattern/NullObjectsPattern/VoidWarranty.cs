namespace NullObjectsPattern
{
    using System;

    internal class VoidWarranty : IWarranty
    {
        [ThreadStatic]
        private static VoidWarranty instance;

        private VoidWarranty() { }

        public static VoidWarranty Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new VoidWarranty();
                }

                return instance;
            }
        }

        public void Claim(DateTime onDate, Action onValidClaim) { }
    }
}
