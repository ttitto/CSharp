namespace InterestCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InterestCalculator
    {
        private decimal money;
        private double interest;
        private int years;
        private decimal paybackValue;

        public InterestCalculator(decimal money, double interest, int years, CalculateInterest del)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.PaybackValue = del(money, interest, years);
        }

        public delegate decimal CalculateInterest(decimal moneySum, double interest, int years);

        public decimal Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public double Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                if (value < 0)
                {
                    throw new FormatException("Interest can not be negative!");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new FormatException("Period can not be negative!");
                }

                this.years = value;
            }
        }

        public decimal PaybackValue
        {
            get { return this.paybackValue; }
            private set { this.paybackValue = value; }
        }
    }
}
