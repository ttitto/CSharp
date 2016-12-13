namespace ObserverEvolutionToDotNet
{
    using System;

    public class Logger
    {
        public readonly IObserver<Tuple<string, string>> AfterDoMore;
        public readonly IObserver<string> AfterDoSomethingWith;

        public Logger()
        {
            this.AfterDoMore = new NotificationSink<Tuple<string, string>>((sender, data) =>
            {
                this.AfterDoMoreHandler(sender, data);
            });

            this.AfterDoSomethingWith = new NotificationSink<string>((sender, data) => {
                this.AfterDoSomethingWithHandler(sender, data);
            });
        }

        private void AfterDoMoreHandler(object sender, Tuple<string, string> data)
        {
            Console.WriteLine($"Writing down.{data.Item1.ToUpper() + data.Item2}");
        }

        public void AfterDoSomethingWithHandler(object sender, string data)
        {
            Console.WriteLine($"Writing down.{data.ToUpper()}");
        }
    }
}
