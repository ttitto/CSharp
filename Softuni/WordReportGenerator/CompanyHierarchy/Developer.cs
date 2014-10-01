namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Developer : RegularEmployee, IDeveloper
    {
        private IList<IProject> projects;

        public Developer(string id, string firstName, string lastName, decimal salary, Department department, IList<IProject> projects)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public IList<IProject> Projects
        {
            get
            {
                return this.projects;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Projects", "Projects can not be null!");
                }

                this.projects = value;
            }
        }
        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format("\nProjects: \n{0}", string.Join("\n", this.Projects));
        }
    }
}