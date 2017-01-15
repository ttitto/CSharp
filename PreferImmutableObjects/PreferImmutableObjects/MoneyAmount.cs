namespace PreferImmutableObjects
{
    internal class MoneyAmount
    {
        public decimal Amount { get; }
        public string CurrencySymbol { get; }

        public MoneyAmount(decimal amount, string currencySymbol)
        {
            this.Amount = amount;
            this.CurrencySymbol = currencySymbol;
        }
        public MoneyAmount Scale(decimal factor) => new MoneyAmount(this.Amount * factor, this.CurrencySymbol);

        public override string ToString()
        {
            return $"{this.Amount} {this.CurrencySymbol}";
        }
    }
}