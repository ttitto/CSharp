namespace ObserverEvolutionToDotNet
{
    using System;

    public class UserInterface : IObserver
    {
        public void Update(ISubject sender, string data)
        {
            Console.WriteLine($"Hey user, look at this. {data.ToUpper()}");
        }
    }
}
