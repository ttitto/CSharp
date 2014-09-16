using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    public abstract class Student : Person
    {
        private string studentNumber;
        private float averageGrade;

        public Student(string fName, string lName, string studentNumber, int age=0)
            :base(fName, lName, age)
        {
            this.StudentNumber = studentNumber;
        }

        public Student(string fName, string lName, string studentNumber, float averageGrade, int age=0)
            : this(fName, lName, studentNumber,age)
        {
            this.AverageGrade = averageGrade;
        }
        public Student(string fName, string lName, int age = 0)
            : base(fName, lName, age) { }

        public string StudentNumber
        {
            get { return this.studentNumber; }
            set
            {
                if (null == value) throw new ArgumentNullException("Student number can not be null!");
                this.studentNumber = value;
            }
        }

        public float AverageGrade
        {
            get { return this.averageGrade; }
            set { this.averageGrade = value; }
        }

        public override string ToString()
        {
            string baseStr=base.ToString();
            return baseStr + string.Format(", Student number: {0}, Average grade: {1}", this.StudentNumber, this.AverageGrade);
        }
    }
}
