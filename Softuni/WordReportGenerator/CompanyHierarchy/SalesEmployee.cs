namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private IList<ISale> sales;

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, Department department, IList<ISale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public IList<ISale> Sales
        {
            get
            {
                return this.sales;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Sales", "Sales can not be null!");
                }

                this.sales = value;
            }
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format("\nSales: ", string.Join("\n", this.Sales));
        }
    }
}