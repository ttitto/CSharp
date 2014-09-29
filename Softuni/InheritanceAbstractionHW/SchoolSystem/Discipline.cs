namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Discipline : IDetail
    {
        private string name;
        private int lecturesNumber;
        private IList<Student> students;
        private string detail;

        public Discipline(string name, IList<Student> students, int lecturesNumber, string detail = null)
        {
            this.Name = name;
            this.Students = students;
            this.LecturesNumber = lecturesNumber;
            this.Detail = detail;
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Students list can not be null!");
                }

                this.students = value;
            }
        }

        public int LecturesNumber
        {
            get
            {
                return this.lecturesNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("LecturesNumber", "The number of lectures can not be negative!");
                }

                this.lecturesNumber = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name", "Discipline name can not be null or empty!");
                }

                this.name = value;
            }
        }

        public string Detail
        {
            get
            {
                return this.detail;
            }

            set
            {
                this.detail = value;
            }
        }
    }
}