namespace ObserverEvolutionToDotNet
{
    using System;

    public class UserInterface : IObserver
    {
        public void Update(ISubject sender)
        {
            Console.WriteLine($"Hey user, look at this. {sender.Data.ToUpper()}");
        }
    }
}
