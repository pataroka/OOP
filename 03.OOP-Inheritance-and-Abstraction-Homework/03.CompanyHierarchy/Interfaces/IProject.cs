namespace _03.CompanyHierarchy.Interfaces
{
    using System;

    using _03.CompanyHierarchy.Models;

    internal interface IProject
    {
        string Name { get; set; }

        string Details { get; set; }

        DateTime StartDate { get; set; }

        ProjectState State { get; set; }

        void CloseProject();
    }
}