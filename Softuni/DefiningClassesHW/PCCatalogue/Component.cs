using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCatalogue
{
    public abstract class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name,decimal price, string details=null)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (null == value) throw new ArgumentNullException("Component name can not be null");
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0) throw new ArgumentException("Component price can not be negative!");
                this.price = value;
            }
        }

        public override string ToString()
        {
            string compToString = string.Format("Name:{0}, Price: {1:C}", this.Name, this.Price);
            if (null != this.Details)
            {
                compToString += string.Format(", Details: {0}",this.Details);
            }
            return compToString;
        }
    }
}
