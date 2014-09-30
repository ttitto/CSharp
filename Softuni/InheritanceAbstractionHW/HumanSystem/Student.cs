namespace HumanSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("FacultyNumber", "FacultyNumber can not be null or empty!");
                }

                if (value.Length < 5 || value.Length > 10)
                {
                    throw new FormatException("Faculty number needs to contain from 5 to 10 chars");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" faculty number: {0}", this.FacultyNumber);
        }
    }
}