using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Age = age;
            this.Name = name;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null) { }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid name!");
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set { 
                if(value<1 || value>100) throw new ArgumentException("Age is outside the allowed range!");
                this.age = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { 
                if(null!=value && (value.Length==0 || !value.Contains("@"))) throw new ArgumentException("Invalid email!");
                this.email = value; }
        }

        public override string ToString()
        {
            return string.Format("name: {0}, age: {1}", this.Name, this.Age)+(this.Email==null?"":", email: "+this.Email);
        }
    }
}
