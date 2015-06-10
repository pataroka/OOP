namespace _03.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    using _03.CompanyHierarchy.Models;

    internal interface ISalesEmployee
    {
        ISet<Sale> Sales { get; set; }

        void AddSales(ISet<Sale> sales);

        string ToString();
    }
}