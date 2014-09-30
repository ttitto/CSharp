namespace CompanyHierarchy
{
    using System;

    public interface IProject
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public ProjectStates State { get; set; }

        public string Detail { get; set; }

        public void CloseProject();
    }
}