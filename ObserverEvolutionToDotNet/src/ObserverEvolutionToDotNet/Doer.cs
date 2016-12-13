namespace ObserverEvolutionToDotNet
{
    using System;
    using System.Collections.Generic;

    public class Doer : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string data = string.Empty;

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
            this.data = data;
            this.AfterDoSomethingWith(data);
        }

        public void DoMore(string appendData)
        {
            this.data += appendData;
        }

        public void AfterDoSomethingWith(string data)
        {
            foreach (IObserver observer in this.observers)
            {
                observer.AfterDoSomethingWith(this, data);
            }
        }

        public void AfterDoMore(string completeData, string appendedData)
        {
            foreach (IObserver observer in this.observers)
            {
                observer.AfterDoMore(this, completeData  , appendedData);
            }
        }
    }
}
