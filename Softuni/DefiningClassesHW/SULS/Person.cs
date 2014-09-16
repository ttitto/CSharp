using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    public abstract class Person
    {
        private string fName;
        private string lName;
        private int age;

        public Person(string fName, string lName)
        {
            this.FName = fName;
            this.LName = lName;
        }
        public Person(string fName, string lName, int age)
            : this(fName, lName)
        {
            this.Age = age;
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0) throw new ArgumentException("Age can not be negative");
                this.age = value;
            }
        }

        public string LName
        {
            get { return this.lName; }
            set
            {
                if (value.Length < 3 || null == value) throw new ArgumentException("Invalid last name");
                this.lName = value;
            }
        }


        public string FName
        {
            get { return this.fName; }
            set
            {
                if (value.Length < 3 || null == value) throw new ArgumentException("Invalid first name");
                this.fName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{3}: Name: {0} {1}, {2} years old", this.FName, this.LName, this.Age, GetType().Name);
        }

    }
}
