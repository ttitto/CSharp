namespace HumanSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Worker : Human
    {
        private decimal weekSalary;
        private float workHoursPerDay;

        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public Worker(string firstName, string lastName, decimal weekSalary, float workHoursPerDay)
            : this(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public float WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                this.weekSalary = value;
            }
        }

        public decimal MoneyPerHour(int daysPerWeek)
        {
            return this.WeekSalary / (decimal)(daysPerWeek * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(
                ", weekly salary: {0:N2}, daily work hours: {0:N2}",
                this.WeekSalary,
                this.WorkHoursPerDay);
        }
    }
}