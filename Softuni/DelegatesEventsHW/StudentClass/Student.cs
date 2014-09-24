namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Student
    {
        private string name;
        private uint age;

        public Student(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
        }

        public event EventHandler<PropertyChangedEventArgs<string>> PropertyChanged;

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
                    throw new ArgumentException("Student's name can not be null or empty");
                }
                OnPropertyChanged(new PropertyChangedEventArgs<string>("Name", this.name, value));
                this.name = value;
            }
        }


        public uint Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs<string> e)
        {
            if (null != PropertyChanged)
            {
                PropertyChanged(this, e);
            }
        }


    }
}
