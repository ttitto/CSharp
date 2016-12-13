namespace ObserverEvolutionToDotNet
{
    using System;

    public class Logger
    {
        public void AfterDoMore(object sender, Tuple<string, string> data)
        {
            Console.WriteLine($"Writing down.{data.Item1.ToUpper() + data.Item2}");
        }

        public void AfterDoSomethingWith(object sender, string data)
        {
            Console.WriteLine($"Writing down.{data.ToUpper()}");
        }
    }
}
