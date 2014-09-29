namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class People : IDetail
    {
        private string name;
        private string detail;

        protected People(string name)
        {
            this.Name = name;
        }

        protected People(string name, string detail)
            : this(name)
        {
            this.Detail = detail;
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
                    throw new ArgumentNullException("Name", "Name can not be null or empty!");
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