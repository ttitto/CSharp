namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAccount
    {
        ICustomer Customer { get; set; }

        decimal Balance { get; }

        decimal MonthlyInterestRate { get; }

        decimal CalculateRate(double months);
    }
}