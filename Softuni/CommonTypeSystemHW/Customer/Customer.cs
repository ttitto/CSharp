namespace Customer
{
    using System;
    using System.Collections.Generic;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private long id;
        private string firstName;
        private string middleName;
        private string lastName;
        private string mobilePhone;
        private string email;
        private IList<Payment> payments;
        private CustomerType type;

        public Customer(long id, string firstName, string middleName, string lastName, string mobilePhone, string email, CustomerType type, List<Payment> payments)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments;
            this.Type = type;
        }

        public CustomerType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }

        public IList<Payment> Payments
        {
            get
            {
                return this.payments;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Payments", "Payments list can not be null!");
                }

                this.payments = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email", "Email can not be null or empty!");
                }

                this.email = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("MobilePhone", "MobilePhone can not be null or empty!");
                }

                this.mobilePhone = value;
            }
        }

        public long Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value == 0 || value.ToString().Length != 10)
                {
                    throw new ArgumentOutOfRangeException("Id", "Customer Id is out of the allowed range!");
                }

                this.id = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("LastName", "LastName can not be null or empty!");
                }

                this.lastName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("MiddleName", "MiddleName can not be null or empty!");
                }

                this.middleName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("FirstName", "FirstName can not be null or empty!");
                }

                this.firstName = value;
            }
        }

        public override int GetHashCode()
        {
            string hashCode = this.FirstName + this.LastName + this.MiddleName + this.Id;
            return hashCode.GetHashCode();
        }

        public override string ToString()
        {
            string customerString = string.Format(
                "ID: {0}, Name: {1} {2}, payments: {3}",
                this.Id,
                this.FirstName,
                this.LastName,
                string.Join(", ", this.Payments));

            return customerString;
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;
            if (customer == null)
            {
                return false;
            }

            if (customer.Id == this.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Customer firstCustomer, Customer secondCustomer)
        {
            return Object.Equals(firstCustomer, secondCustomer);
        }

        public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
        {
            return !Object.Equals(firstCustomer, secondCustomer);
        }

        public object Clone()
        {
            Customer newCustomer = this.MemberwiseClone() as Customer;
            if (null == newCustomer)
            {
                throw new ArgumentNullException("Object can not be casted to type Customer!");
            }

            newCustomer.Payments = new List<Payment>(this.Payments.Count);
            foreach (var payment in this.Payments)
            {
                newCustomer.Payments.Add(payment.Clone() as Payment);
            }

            return newCustomer;
        }

        public int CompareTo(Customer other)
        {
            string thisFullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            string otherFullName = other.FirstName + " " + other.MiddleName + " " + other.LastName;

            if (thisFullName.CompareTo(otherFullName) != 0)
            {
                return thisFullName.CompareTo(otherFullName);
            }
            else
            {
                return this.Id.CompareTo(other.Id);
            }
        }
    }
}