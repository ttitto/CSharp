namespace CompanyHierarchy
{
    using System.Collections.Generic;

    public interface IDeveloper : IRegularEmployee
    {
        IList<IProject> Projects { get; set; }
    }
}