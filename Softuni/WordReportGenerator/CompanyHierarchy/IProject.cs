namespace CompanyHierarchy
{
    using System;

    public interface IProject
    {
        string Name { get; set; }

        DateTime StartDate { get; set; }

        ProjectState State { get; set; }

        string Detail { get; set; }

        void CloseProject();
    }
}