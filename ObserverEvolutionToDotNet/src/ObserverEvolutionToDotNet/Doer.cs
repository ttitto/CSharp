namespace ObserverEvolutionToDotNet
{
    using System;
    using System.Collections.Generic;

    public class Doer : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public string Data { get; private set; }

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void DoSomethingWith(string data)
        {
            this.Data = data;
            this.Notify();
        }

        public void Notify()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update(this);
            }
        }
    }
}
