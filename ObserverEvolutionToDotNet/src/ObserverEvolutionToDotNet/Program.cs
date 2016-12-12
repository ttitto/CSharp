namespace ObserverEvolutionToDotNet
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var doer = new Doer();
            doer.Attach(new UserInterface());
            doer.Attach(new Logger());
            doer.DoSomethingWith("my data");
            Console.ReadLine();
        }
    }
}
