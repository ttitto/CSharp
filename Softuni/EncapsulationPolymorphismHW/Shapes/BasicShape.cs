namespace Shapes
{
    public abstract class BasicShape : IShape
    {
        private double height;
        private double width;

        public BasicShape(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
