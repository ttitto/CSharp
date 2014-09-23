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
            if (this.FacNumber < student.FacNumber)
            {
                return -1;
            }
            else if (this.FacNumber == student.FacNumber)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
