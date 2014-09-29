using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReportGenerator.DeleteMe
{
    public interface ISalesEmployee : IEmployee
    {
        List<Sale> Sales { get; set; }
    }
    
    public class Sale
    {
    }
}
