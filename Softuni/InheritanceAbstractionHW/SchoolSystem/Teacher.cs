namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Teacher : People
    {
        private IList<Discipline> disciplines;

        public Teacher(string name)
            : base(name)
        {
            this.Disciplines = new List<Discipline>();
        }

        public Teacher(string name, List<Discipline> disciplines)
            : this(name)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, List<Discipline> disciplines, string detail)
            : this(name, disciplines)
        {
            this.Detail = detail;
        }

        public IList<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Disciplines", "Disciplines can not be null!");
                }

                this.disciplines = value;
            }
        }
    }
}