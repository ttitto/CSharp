namespace PreferImmutableObjects
{
    internal class MoneyAmount
    {
        public decimal Amount { get; set; }
        public string CurrencySymbol { get; set; }

        public override string ToString()
        {
            return $"{this.Amount} {this.CurrencySymbol}";
        }
    }
}