namespace BankSystem
{
    using System;
    using System.Collections.Generic;

    public class TestBankSystem
    {
        public static void Main()
        {
            ICustomer pesho = new IndividualCustomer("Petar Petrov");
            ICustomer agroCompany = new CompanyCustomer("Agro Company Ltd.");

            IAccount mortgageAccInd = new MortgageAccount(pesho, 1024m, 5.3m);
            IAccount mortgageAccComp = new MortgageAccount(agroCompany, 1024m, 5.3m);
            IAccount loanAccInd = new LoanAccount(pesho, 1024m, 5.3m);
            IAccount loanAccComp = new LoanAccount(agroCompany, 1024m, 5.3m);
            IAccount depositAccIndBig = new DepositAccount(pesho, 1024m, 5.3m);
            IAccount depositAccIndSmall = new DepositAccount(pesho, 999m, 5.3m);
            IAccount depositAccComp = new DepositAccount(agroCompany, 11024m, 4.3m);

            List<IAccount> accounts = new List<IAccount>()
            {
                mortgageAccInd,
                mortgageAccComp,
                loanAccInd,
                loanAccComp,
                depositAccIndBig,
                depositAccIndSmall,
                depositAccComp
            };

            foreach (var acc in accounts)
            {
                Console.WriteLine(
                    "{5} {0,-15}: {1:N2}, {2:N2}, {3:N2}, {4:N2}",
                    acc.GetType().Name,
                    acc.CalculateRate(2),
                    acc.CalculateRate(3),
                    acc.CalculateRate(10),
                    acc.CalculateRate(13),
                    acc.Customer.GetType().Name);
            }
        }
    }
}