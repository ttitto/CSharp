namespace CompanyHierarchy
{
    public abstract class Employee : Person, IEmployee
    {
        private Department department;
        private decimal salary;

        public Employee(string id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public Department Department
        {
            get
            {
                return this.department;
            }

            set
            {
                this.department = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                this.salary = value;
            }
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format("\nSalary: {0:N2}\nDepartment: {1}", this.Salary, this.Department);
        }
    }
}