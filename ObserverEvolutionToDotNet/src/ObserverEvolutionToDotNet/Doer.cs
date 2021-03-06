﻿namespace ObserverEvolutionToDotNet
{
    using System;
    using System.Collections.Generic;

    public class Doer 
    {
        public event EventHandler<string> AfterDoSomethingWith;
        public event EventHandler<Tuple<string, string>> AfterDoMore;
        private string data = string.Empty;

        public void DoSomethingWith(string data)
        {
            this.data = data;
            OnAfterDoSomethingWith(this.data);
        }

        public void DoMore(string appendData)
        {
            this.data += appendData;
            OnAfterDoMore(this.data, appendData);
        }

        private void OnAfterDoSomethingWith(string data)
        {
            this.AfterDoSomethingWith?.Invoke(this, data);
        }

        private void OnAfterDoMore(string completeData, string appendedData)
        {
            this.AfterDoMore?.Invoke(this, Tuple.Create(completeData, appendedData));
        }
    }
}
