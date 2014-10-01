namespace CompanyHierarchy
{
    using System;

    public class Sale : ISale
    {
        private string productName;
        private DateTime saleDate;
        private decimal price;

        public Sale(string productName, DateTime saleDate, decimal price)
        {
            this.ProductName = productName;
            this.SaleDate = saleDate;
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
                this.price = value;
            }
        }

        public DateTime SaleDate
        {
            get
            {
                return this.saleDate;
            }

            set
            {
                if (value == default(DateTime))
                {
                    throw new ArgumentException("Datetime is invalid!");
                }

                this.saleDate = value;
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
                    throw new ArgumentNullException("Name", "Name can not be null or empty!");
                }

                this.productName = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Product: {0}, date: {1:dd.MM.yyyy}, Price: {2:N2}",
                this.ProductName,
                this.SaleDate,
                this.Price);
        }
    }
}