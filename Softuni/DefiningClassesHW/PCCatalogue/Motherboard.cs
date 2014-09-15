using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalogue
{
    class Motherboard:Component
    {
        public Motherboard(string name, decimal price, string details=null)
        :base(name, price, details){ }
    }
}
