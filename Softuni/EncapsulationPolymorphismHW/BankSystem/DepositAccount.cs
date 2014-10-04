namespace BankSystem
{
    using System;

    public class DepositAccount : Account, IAccount, IDepositable, IWithdrawable
    {
        public DepositAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateRate(double months)
        {
            if (this.Balance < 1000 && this.Balance >= 0)
            {
                return this.Balance;
            }
            else
            {
                return base.CalculateRate(months);
            }
        }
    }
}