namespace BankSystem
{
    public class CompanyCustomer : Customer, ICustomer
    {
        public CompanyCustomer(string name)
            : base(name)
        {
            this.Name = name;
        }
    }
}