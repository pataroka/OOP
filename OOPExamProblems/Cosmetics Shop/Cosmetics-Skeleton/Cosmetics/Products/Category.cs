namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private const int MinCategoryNameLength = 2;
        private const int MaxCategoryNameLength = 15;

        private readonly IList<IProduct> products;

        private string name;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
                Validator.CheckIfStringLengthIsValid(value, MaxCategoryNameLength, MinCategoryNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", MinCategoryNameLength, MaxCategoryNameLength));
                
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!this.products.Contains(cosmetics))
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }

            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} category - {1} {2} in total{3}", this.Name, this.products.Count, this.products.Count == 1 ? "product" : "products", Environment.NewLine);

            var sortedProducts = from p in this.products 
                                 orderby p.Brand ascending, p.Price descending 
                                 select p;

            foreach (var product in sortedProducts)
            {
                sb.AppendLine(product.Print());
            }

            return sb.ToString().Trim();
        }
    }
}