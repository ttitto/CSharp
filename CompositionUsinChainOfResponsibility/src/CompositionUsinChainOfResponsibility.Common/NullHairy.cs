using System;

namespace CompositionUsinChainOfResponsibility.Common
{
    public class NullHairy : IHairy
    {
        private static IHairy instance;

        public static IHairy Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new NullHairy();
                }

                return instance;
            }
        }

        public void GrowHair()
        {
            // ignore
        }
    }
}
