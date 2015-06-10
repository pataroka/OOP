namespace _03.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    using _03.CompanyHierarchy.Models;

    internal interface IManager
    {
        ISet<Employee> Employees { get; set; }

        void AddEmployees(ISet<Employee> employees);

        string ToString();
    }
}