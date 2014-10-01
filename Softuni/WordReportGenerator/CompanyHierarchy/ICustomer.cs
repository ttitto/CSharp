namespace CompanyHierarchy
{
    public interface ICustomer : IPerson
    {
        decimal NetPurchaseAmount { get; set; }
    }
}