namespace CheckDigit
{
    using System.Collections.Generic;

    internal static class Int64Extensions
    {
        public static IEnumerable<int> DigitsFromLowest(this long number)
        {
            do
            {
                yield return (int)number % 10;
                number /= 10;
            } while (number > 0);
        }
    }
}
