namespace Customer
{
    using System;

    public class Payment : ICloneable
    {
        private string productName;
        private decimal price;

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "The price can not be negative!");
                }

                this.price = value;
            }
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ProductName", "ProductName can not be null or empty!");
                }

                this.productName = value;
            }
        }

        public object Clone()
        {
            Payment newPayment = this.MemberwiseClone() as Payment;
            if (null == newPayment)
            {
                throw new ArgumentNullException("Cloned object can not be casted to type Payment!");
            }

            return newPayment;
        }

        public override string ToString()
        {
            return string.Format("[{0} - {1}]", this.ProductName, this.Price);
        }
    }
}