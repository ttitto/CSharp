namespace InterestCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InterestCalculatorClass
    {
        public static void Main()
        {
            InterestCalculator intCalcCompound = new InterestCalculator(2500m, 7.2, 15, GetSimpleInterest);
            Console.WriteLine("{0:0.0000}", intCalcCompound.PaybackValue);

            InterestCalculator intCalcSimple = new InterestCalculator(500m, 5.6, 10, GetCompoundInterest);
            Console.WriteLine("{0:0.0000}", intCalcSimple.PaybackValue);
        }

        private static decimal GetSimpleInterest(decimal moneySum, double interest, int years)
        {
            // A = sum * (1 + interest * years)
            decimal simpleInterest = moneySum * (decimal)(1 + (interest * years / 100));
            return simpleInterest;
        }

        private static decimal GetCompoundInterest(decimal moneySum, double interest, int years)
        {
            // A = sum * (1 + interest / n)year * n, n=12
            decimal compoundInterest = moneySum * (decimal)Math.Pow(1 + (interest / 12 / 100), years * 12);
            return compoundInterest;
        }
    }
}
