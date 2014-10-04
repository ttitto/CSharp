namespace Shapes
{
    using System;

    public class Triangle : BasicShape, IShape
    {
        private double includedAngle;

        public Triangle(double width, double height, double includedAngle)
            : base(width, height)
        {
            this.IncludedAngle = includedAngle;
        }

        public double IncludedAngle
        {
            get
            {
                return this.includedAngle;
            }

            set
            {
                if (value < 0 || value > 360)
                {
                    throw new ArgumentOutOfRangeException(
                        "IncludedAngle", "The included angle accepts only values between 0 and 360 deg");
                }

                this.includedAngle = value;
            }
        }

        public override double CalculateArea()
        {
            return (Math.Sin(this.IncludedAngle * Math.PI / 180) * this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            // law of cosines
            return this.Width + this.Height + Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height) - (2 * this.Height * this.Width * Math.Cos(this.IncludedAngle * Math.PI / 180)));
        }
    }
}