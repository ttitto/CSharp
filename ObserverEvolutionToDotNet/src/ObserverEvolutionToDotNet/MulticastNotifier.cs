namespace ObserverEvolutionToDotNet
{
    using System.Collections.Generic;

    public class MulticastNotifier<T>
    {
        private IList<IObserver<T>> invocationList;
        private MulticastNotifier<T> notifier;
        private IObserver<T> observer;

        private MulticastNotifier(MulticastNotifier<T> notifier, IObserver<T> observer)
        {
            this.invocationList = new List<IObserver<T>>(notifier.invocationList);
            this.invocationList.Add(observer);
        }

        private MulticastNotifier(IObserver<T> observer)
        {
            this.invocationList = new List<IObserver<T>>() { observer };
        }

        public void Notify(object sender, T data)
        {
            foreach (IObserver<T> observer in this.invocationList)
            {
                observer.Update(sender, data);
            }
        }

        public static MulticastNotifier<T> operator +(MulticastNotifier<T> notifier, IObserver<T> observer)
        {
            if (notifier == null)
            {
                return new MulticastNotifier<T>(observer);
            }

            return new MulticastNotifier<T>(notifier, observer);
        }
    }
}
