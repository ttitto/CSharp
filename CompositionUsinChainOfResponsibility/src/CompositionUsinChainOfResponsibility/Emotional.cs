namespace CompositionUsinChainOfResponsibility
{
    using System;
    using Common;

    public class Emotional : IEmotional
    {
        private readonly string owner;
        private readonly string laughingSound;

        public Emotional(string owner, string laughingSound)
        {
            this.owner = owner;
            this.laughingSound = laughingSound;
        }

        public void BeHappy()
        {
            Console.WriteLine($"{this.owner}: {this.laughingSound}");
        }
    }
}