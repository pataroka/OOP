namespace _03.CompanyHierarchy.Interfaces
{
    internal interface IPerson
    {
        string ID { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string ToString();
    }
}