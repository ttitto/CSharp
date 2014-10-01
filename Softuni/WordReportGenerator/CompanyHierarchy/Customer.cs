namespace CompanyHierarchy
{
    public class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(string id, string firstName, string lastName)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("{0:N2}", this.NetPurchaseAmount);
        }
    }
}