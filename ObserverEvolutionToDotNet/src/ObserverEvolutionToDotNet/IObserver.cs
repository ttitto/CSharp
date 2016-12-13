namespace ObserverEvolutionToDotNet
{
    public interface IObserver
    {
        void Update(ISubject sender, string data);
    }
}
