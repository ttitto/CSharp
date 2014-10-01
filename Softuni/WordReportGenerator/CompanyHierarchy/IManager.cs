namespace CompanyHierarchy
{
    using System.Collections.Generic;

    public interface IManager : IEmployee
    {
        IList<IEmployee> Employees { get; set; }
    }
}