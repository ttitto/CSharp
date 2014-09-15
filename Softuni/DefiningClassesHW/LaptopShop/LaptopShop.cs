using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class LaptopShopClass
    {
        static void Main(string[] args)
        {
            Battery lion = new Battery("Li-Ion");
            Laptop lpt_first = new Laptop("B590", "Lenovo", 869);
            Laptop lpt_second = new Laptop("Aspire E3-111-C5GL", "Acer", "N2830", "Radeon", lion, (float)3.5, 11, (decimal)259.49);

            Console.WriteLine(lpt_first.ToString());
            Console.WriteLine();
            Console.WriteLine(lpt_second.ToString());
        }
    }
}
