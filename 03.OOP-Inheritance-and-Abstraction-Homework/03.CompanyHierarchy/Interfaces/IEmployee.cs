namespace _03.CompanyHierarchy.Interfaces
{
    using _03.CompanyHierarchy.Models;

    internal interface IEmployee
    {
        Department Department { get; set; }

        decimal Salary { get; set; }

        string ToString();
    }
}