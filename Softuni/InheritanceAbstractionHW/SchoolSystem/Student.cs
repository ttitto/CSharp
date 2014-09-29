namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : People
    {
        private static IList<string> takenClassNumbers;
        private string uniqueClassNumber;

        static Student()
        {
            Student.takenClassNumbers = new List<string>();
        }

        public Student(string name, string uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
            Student.takenClassNumbers.Add(uniqueClassNumber);
        }

        public Student(string name, string uniqueClassNumber, string detail)
            : this(name, uniqueClassNumber)
        {
            this.Detail = detail;
        }

        public string UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("UniqueClassNumber", "UniqueClassNumber can not be null or empty!");
                }

                if (takenClassNumbers.Contains(value))
                {
                    throw new ArgumentException("The class number was assigned to another student");
                }

                this.uniqueClassNumber = value;
            }
        }
    }
}