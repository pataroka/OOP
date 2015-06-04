using System;
using System.Collections.Generic;
using System.Text;


namespace _03.PCCatalog
{
    class Computer
    {
        private string name;
        public Dictionary<string, Component> Components { get; set; }
        private decimal price;

        public Computer(string name) : this (name, new Dictionary<string, Component>())
        {
        }

        public Computer(string name, Dictionary<string, Component> components )
        {
            Name = name;
            Components = components;
            Price = 0.00m;
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

        public decimal Price
        {
            get
            {
                if (Components.Count == 0)
                {
                    price = 0.00m;
                }
                else
                {
                    price = 0.00m;
                    foreach (var component in Components)
                    {
                        price += component.Value.Price;
                    }
                }
                return price;
            }
            set { price = value;}
        }

        public void DisplayInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}\n", Name));
            if (Components.Count == 0)
            {
                sb.Append("Add components to PC configuration!\n");
            }
            else
            {
                foreach (var component in Components)
                {
                    sb.Append(String.Format("{0}: {1}, {2}\nPrice: {3:C}\n", component.Key, component.Value.Name, component.Value.Details ?? "", component.Value.Price));
                }
            }
            sb.Append(String.Format("Total price: {0:C}\n", Price));
            Console.WriteLine(sb.ToString());
        }
    }
}
