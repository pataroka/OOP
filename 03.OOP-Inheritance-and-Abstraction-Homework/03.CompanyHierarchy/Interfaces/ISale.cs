namespace _03.CompanyHierarchy.Interfaces
{
    using System;

    internal interface ISale
    {
        string ProductName { get; set; }

        DateTime SaleDate { get; set; }

        decimal ProductPrice { get; set; }
    }
}