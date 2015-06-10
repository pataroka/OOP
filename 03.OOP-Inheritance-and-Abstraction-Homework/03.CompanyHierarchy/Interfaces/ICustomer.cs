namespace _03.CompanyHierarchy.Interfaces
{
    internal interface ICustomer
    {
        decimal PurchasesAmmount { get; set; }

        void AddPurchasePrice(decimal purchasePrice);

        string ToString();
    }
}