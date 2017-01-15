namespace PreferImmutableObjects
{
    sealed class MoneyAmount
    {
        public decimal Amount { get; }
        public string CurrencySymbol { get; }

        public MoneyAmount(decimal amount, string currencySymbol)
        {
            this.Amount = amount;
            this.CurrencySymbol = currencySymbol;
        }
        public MoneyAmount Scale(decimal factor) => new MoneyAmount(this.Amount * factor, this.CurrencySymbol);

        public override bool Equals(object obj) => this.Equals(obj as MoneyAmount);

        public override string ToString()
        {
            return $"{this.Amount} {this.CurrencySymbol}";
        }

        private bool Equals(MoneyAmount other) =>
            other != null &&
            this.Amount == other.Amount &&
            this.CurrencySymbol == other.CurrencySymbol;
    }
}