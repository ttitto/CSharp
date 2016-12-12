namespace ObserverEvolutionToDotNet
{
    using System;

    public class UserInterface : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Hey user, look at this.");
        }
    }
}
