namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEmployee
    {
        decimal Salary { get; set; }

        public Departments Department { get; set; }
    }
}