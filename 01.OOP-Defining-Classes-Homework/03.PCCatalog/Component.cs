using System;


namespace _03.PCCatalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, decimal price) : this (name, null, price)
        {
        }

        public Component(string name, string details, decimal price)
        {
            Name = name;
            Details = details;
            Price = price;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Trim() == String.Empty || value == null)
                {
                    throw new ArgumentException("Name must have a value!");
                }
                name = value;
            }
        }

        public string Details
        {
            get { return details; }
            private set
            {
                if (value != null)
                {
                    if (value.Trim() == String.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                details = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cannot be a negative number!");
                }
                price = value;
            }
        }
    }
}
