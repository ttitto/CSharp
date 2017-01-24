namespace CheckDigit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ControlDigitAlgorithm
    {
        private Func<long, IEnumerable<int>> GetDigitsOf { get; }
        private IEnumerable<int> MultiplyingFactors { get; }
        private int Modulo { get; }

        public ControlDigitAlgorithm(Func<long, IEnumerable<int>> getDigitsOf, IEnumerable<int> multiplyingFactors, int modulo)
        {
            this.GetDigitsOf = getDigitsOf;
            this.MultiplyingFactors = multiplyingFactors;
            this.Modulo = modulo;
        }

        public int GetControllDigit(long number) =>
            this.GetDigitsOf(number)
            .Zip(this.MultiplyingFactors, (a, b) => a * b)
            .Sum()
            % this.Modulo;
    }
}
