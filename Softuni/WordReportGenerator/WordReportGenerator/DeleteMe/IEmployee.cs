using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReportGenerator.DeleteMe
{
    public interface IEmployee : IPerson
    {
        Department Department { get; set; }
        decimal Salary { get; set; }
    }

    public enum Department
    {
    }
}
