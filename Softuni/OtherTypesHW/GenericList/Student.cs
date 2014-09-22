namespace GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        public Student(string name, int facNumber)
        {
            this.Name = name;
            this.FacNumber = facNumber;
        }

        public string Name { get; set; }

        public int FacNumber { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.FacNumber;
        }
    }
}
