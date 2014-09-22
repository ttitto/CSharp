namespace FractionCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }

            set
            {
                if (value > long.MaxValue || value < long.MinValue)
                {
                    throw new OverflowException("The numerator value is outside the range, allowed for long integers");
                }

                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Denominator can not be zero!");
                }

                if (value > long.MaxValue || value < long.MinValue)
                {
                    throw new OverflowException("The denominator value is outside the range, allowed for long integers");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            checked
            {
                fr1.Numerator *= fr2.Denominator;
                fr2.Numerator *= fr1.Denominator;
                long commonDenom = fr1.Denominator * fr2.Denominator;

                return new Fraction(fr1.Numerator + fr2.Numerator, commonDenom);
            }
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            checked
            {
                fr1.Numerator *= fr2.Denominator;
                fr2.Numerator *= fr1.Denominator;
                long commonDenom = fr1.Denominator * fr2.Denominator;

                return new Fraction(fr1.Numerator - fr2.Numerator, commonDenom);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Numerator / this.Denominator);
        }
    }
}
