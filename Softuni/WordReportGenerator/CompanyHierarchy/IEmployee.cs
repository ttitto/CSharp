namespace CompanyHierarchy
{
    public interface IEmployee : IPerson
    {
        decimal Salary { get; set; }

        Department Department { get; set; }
    }
}