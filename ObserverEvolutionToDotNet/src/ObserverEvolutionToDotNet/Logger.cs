namespace ObserverEvolutionToDotNet
{
    using System;

    public class Logger : IObserver
    {
        public void AfterDoMore(ISubject sender, string completeData, string appendedData)
        {
            Console.WriteLine($"Writing down.{completeData.ToUpper() + appendedData}");
        }

        public void AfterDoSomethingWith(ISubject sender, string data)
        {
            Console.WriteLine($"Writing down.{data.ToUpper()}");
        }
    }
}
