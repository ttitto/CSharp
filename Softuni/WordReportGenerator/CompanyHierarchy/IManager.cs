namespace CompanyHierarchy
{
    using System.Collections.Generic;

    public class IManager
    {
        IEnumerable<IEmployee> Employees { get; set; }
    }
}