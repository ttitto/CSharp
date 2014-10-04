namespace BankSystem
{
    using System;

    public class MortgageAccount : Account, IAccount, IDepositable
    {
        public MortgageAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public override decimal CalculateRate(double months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (months >= 6)
                {
                    return base.CalculateRate(months - 6);
                }
                else
                {
                    return this.Balance;
                }
            }

            if (this.Customer is CompanyCustomer)
            {
                if (months <= 12)
                {
                    return base.CalculateRate(months) / 2;
                }
                else
                {
                    return (base.CalculateRate(12) / 2) + base.CalculateRate(months - 12);
                }
            }

            return base.CalculateRate(months);
        }
    }
}