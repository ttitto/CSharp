namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    public abstract class Person : IPerson
    {
        private static HashSet<string> uniqueIds;

        private string id;
        private string lastName;
        private string firstName;

        static Person()
        {
            Person.uniqueIds = new HashSet<string>();
        }

        public Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Id", "Id can not be null or empty!");
                }

                if (Person.uniqueIds.Contains(value))
                {
                    throw new ArgumentException("Person with this ID already exists!");
                }

                Person.uniqueIds.Add(value);
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

        public override string ToString()
        {
            return string.Format("ID: {0}\nFirst Name: {1}\nLast Name: {2}", this.Id, this.FirstName, this.LastName);
        }
    }
}