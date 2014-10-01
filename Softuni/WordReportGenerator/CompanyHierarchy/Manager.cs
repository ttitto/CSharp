namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Manager : Employee, IManager
    {
        private IList<IEmployee> employees;

        public Manager(string id, string firstName, string lastName, decimal salary, Department department, IList<IEmployee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public IList<IEmployee> Employees
        {
            get
            {
                return this.employees;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Employees", "Employees can not be null!");
                }

                this.employees = value;
            }
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            string employeesStr = string.Empty;

            foreach (var emp in this.Employees)
            {
                employeesStr += emp.Id + ", " + emp.FirstName + " " + emp.LastName;
            }

            return baseStr + string.Format("\nManaged employees: {0}", employeesStr);
        }
    }
}