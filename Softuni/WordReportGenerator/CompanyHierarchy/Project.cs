namespace CompanyHierarchy
{
    using System;

    public class Project : IProject
    {
        private string name;
        private DateTime startDate;
        private ProjectState state;
        private string detail;

        public Project(string name, DateTime startDate, ProjectState state, string detail)
        {
            this.Name = name;
            this.startDate = startDate;
            this.State = state;
            this.Detail = detail;
        }

        public string Detail
        {
            get
            {
                return this.detail;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Detail", "Detail can not be null or empty!");
                }

                this.detail = value;
            }
        }

        public ProjectState State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }

            set
            {
                if (value == default(DateTime))
                {
                    throw new ArgumentException("Datetime is invalid!");
                }

                this.startDate = value;
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
                    throw new ArgumentNullException("Name", "Name can not be null or empty!");
                }

                this.name = value;
            }
        }

        public void CloseProject()
        {
            if (this.State == ProjectState.Open)
            {
                this.State = ProjectState.Closed;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Project: {0}, started: {1:dd.MM.yyyy}, State: {2}, Details: {3}",
                this.Name,
                this.StartDate,
                this.State,
                this.Detail);
        }
    }
}