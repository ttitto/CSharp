namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SchoolClass : IDetail
    {
        private static IList<string> uniqueIds;

        private string uniqueId;
        private IList<Teacher> teachers;
        private IList<Student> students;
        private string detail;

        static SchoolClass()
        {
            SchoolClass.uniqueIds = new List<string>();
        }

        public SchoolClass(string uniqueId, IList<Student> students, IList<Teacher> teachers)
        {
            this.UniqueId = uniqueId;
            this.Teachers = teachers;
            this.Students = students;
            SchoolClass.uniqueIds.Add(uniqueId);
        }

        public string UniqueId
        {
            get
            {
                return this.uniqueId;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("UniqueId", "UniqueId can not be null or empty!");
                }

                if (uniqueIds.Contains(value))
                {
                    throw new ArgumentException("There is another class with this identification!");
                }

                this.uniqueId = value;
            }
        }

        public IList<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Teachers", "Teachers can not be null");
                }

                this.teachers = value;
            }
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
                    throw new ArgumentNullException("Students", "Students can not be null");
                }

                this.students = value;
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