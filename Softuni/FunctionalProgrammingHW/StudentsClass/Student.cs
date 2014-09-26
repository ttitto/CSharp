namespace StudentsClass
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phone;
        private string email;
        private int groupNumber;
        private IList<int> marks;
        private string groupName;

        public Student(
        string firstName,
        string lastName,
        int age,
        string facultyNumber,
        string phone,
        string email,
        int groupNumber,
        string groupName,
        IList<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
            if (null == marks)
            {
                this.Marks = new List<int>();
            }
            else
            {
                this.Marks = marks;
            }
        }

        public string GroupName
        {
            get
            {
                return this.groupName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("GroupName", "GroupName can not be null or empty!");
                }

                this.groupName = value;
            }
        }

        public IList<int> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Marks", "Marks list can not be null!");
                }

                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                this.groupNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email", "Email can not be null or empty!");
                }

                this.email = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                this.phone = value;
            }
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
                    throw new ArgumentNullException("FacultyNumber", "Faculty Number can not be null or empty!");
                }

                this.facultyNumber = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can not be negative!");
                }

                this.age = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("LastName", "Last Name can not be null or empty!");
                }

                this.lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("FirstName", "First Name can not be null or empty!");
                }

                this.firstName = value;
            }
        }

        public override string ToString()
        {
            string marks = string.Join(", ", this.Marks as IEnumerable<int>);
            return string.Format(
                "{0} {1}, fac number: {2}, group: {3}, groupName: {8}, age: {4}, phone: {5}, email: {6}, marks:{{ {7} }}",
                this.FirstName,
                this.lastName,
                this.FacultyNumber,
                this.GroupNumber,
                this.Age,
                this.Phone,
                this.Email,
                marks,
                this.GroupName);
        }
    }
}