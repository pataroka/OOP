namespace _03.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    using _03.CompanyHierarchy.Models;

    internal interface IDeveloper
    {
        ISet<Project> Projects { get; set; }

        void AddProjects(ISet<Project> projects);

        string ToString();
    }
}