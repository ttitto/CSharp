namespace ObserverEvolutionToDotNet
{
    using System;

    public class Logger : IObserver
    {
        public void Update(ISubject sender)
        {
            Console.WriteLine($"Writing down.{sender.Data.ToUpper()}");
        }
    }
}
