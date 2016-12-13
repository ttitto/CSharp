namespace ObserverEvolutionToDotNet
{
    public interface IObserver
    {
        void AfterDoSomethingWith(ISubject sender, string data);
        void AfterDoMore(ISubject sender, string completeData, string appendedData);
    }
}
