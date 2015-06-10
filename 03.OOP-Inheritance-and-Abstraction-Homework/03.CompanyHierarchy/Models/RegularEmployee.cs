namespace _03.CompanyHierarchy.Models
{
    internal class RegularEmployee : Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, Department department, decimal salary)
            : base(id, firstName, lastName, department, salary)
        {
        }
    }
}