namespace GenericList
{
    using System;

    public class Student : IComparable<Student>
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

        public int CompareTo(Student student)
        {
            return this.FacNumber.CompareTo(student.FacNumber);
        }
    }
}
