namespace CompositionUsinChainOfResponsibility.Common
{
    public class NullEmotional : IEmotional
    {
        private static IEmotional instance;

        public static IEmotional Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new NullEmotional();
                }

                return instance;
            }
        }

        public void BeHappy()
        {
            // ignore
        }
    }
}