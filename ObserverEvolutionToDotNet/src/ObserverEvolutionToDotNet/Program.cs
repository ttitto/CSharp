namespace ObserverEvolutionToDotNet
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var doer = new Doer();

            var userInterface = new UserInterface();
            var logger = new Logger();

            doer.AfterDoSomethingWith += userInterface.AfterDoSomethingWith;
            doer.AfterDoSomethingWith += logger.AfterDoSomethingWith;

            doer.AfterDoMore += logger.AfterDoMore;

            doer.DoSomethingWith("my data");
            doer.DoMore("tail");
            Console.ReadLine();
        }
    }
}
