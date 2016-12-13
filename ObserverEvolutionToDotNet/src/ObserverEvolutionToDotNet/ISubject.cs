namespace ObserverEvolutionToDotNet
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void AfterDoSomethingWith(string data);
        void AfterDoMore(string completeData, string appendedData);
    }
}
