namespace CompanyHierarchy
{
    using System;

    public interface ISale
    {
        public string ProductName { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }
    }
}