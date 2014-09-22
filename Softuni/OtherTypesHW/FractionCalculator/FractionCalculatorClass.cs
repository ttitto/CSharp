namespace FractionCalculator
{
    using System;

    public class FractionCalculatorClass
    {
        public static void Main()
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;

            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);

            Fraction fr1 = new Fraction(9223372036854775807, 2);
            Fraction fr2 = new Fraction(23, 43);
            Fraction divided = fr1 + fr2; // gives runtime error because number overflow

            Console.WriteLine(fr1);
            Console.WriteLine(divided);
        }
    }
}
