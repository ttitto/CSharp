namespace CompositionUsinChainOfResponsibility.Common
{
    public class NullBearded : IBearded
    {
        private static IBearded instance;

        public static IBearded Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NullBearded();
                }

                return instance;
            }
        }

        public void GrowBeard()
        {
            // ignore
        }
    }
}