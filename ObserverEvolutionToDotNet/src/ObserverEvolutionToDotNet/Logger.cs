namespace ObserverEvolutionToDotNet
{
    using System;

    public class Logger : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Writing down.");
        }
    }
}
