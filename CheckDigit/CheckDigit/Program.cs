namespace CheckDigit
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static IEnumerable<int> MultiplyingFactors
        {
            get
            {
                int factor = 3;
                while (true)
                {
                    yield return factor;
                    factor = 4 - factor;
                }
            }
        }

        static int GetControllDigit(long number) =>
            number
            .DigitsFromLowest()
            .Zip(MultiplyingFactors, (a, b) => a * b)
            .Sum()
            % 7;

        static void Main(string[] args)
        {
            int digit = GetControllDigit(12345);
        }
    }
}
