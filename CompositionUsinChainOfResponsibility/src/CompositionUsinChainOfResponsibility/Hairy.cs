namespace CompositionUsinChainOfResponsibility
{
    using System;
    using Common;

    public class Hairy : ChainElement, IHairy
    {
        private readonly string owner;

        public Hairy(string owner, IChainElement next)
            : base(next)
        {
            this.owner = owner;
        }

        public Hairy(string owner)
        {
            this.owner = owner;
        }

        public void GrowHair()
        {
            Console.WriteLine($"{this.owner}: hair gets long");
        }
    }
}