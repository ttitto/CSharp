namespace ObserverEvolutionToDotNet
{
    using System;

    public class UserInterface : IObserver
    {
        public void AfterDoMore(ISubject sender, string completeData, string appendedData)
        {
            Console.WriteLine($"Hey user, look at this. {completeData + appendedData}");
        }

        public void AfterDoSomethingWith(ISubject sender, string data)
        {
            // user interface is not interested on this notification
        }
    }
}
