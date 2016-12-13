namespace ObserverEvolutionToDotNet
{
    using System;

    public class Logger : IObserver
    {
        public void Update(ISubject sender, string data)
        {
            Console.WriteLine($"Writing down.{data.ToUpper()}");
        }
    }
}
