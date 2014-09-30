namespace CompanyHierarchy
{
    using System.Collections.Generic;

    public interface IDeveloper
    {
        IEnumerable<IProject> projects { get; set; }
    }
}