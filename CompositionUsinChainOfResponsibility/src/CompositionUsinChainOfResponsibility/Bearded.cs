namespace CompositionUsinChainOfResponsibility
{
    using System;
    using Common;

    public class Bearded : ChainElement, IBearded
    {
        private readonly string owner;

        public Bearded(string owner, IChainElement next)
            : base(next)
        {
            this.owner = owner;
        }

        public Bearded(string owner)
        {
            this.owner = owner;
        }

        public void GrowBeard()
        {
            Console.WriteLine($"{this.owner}: beard grows");
        }
    }
}
