using System;
using System.Text;


namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string memory;
        private string graphicsCard;
        private string disk;
        private string screen;
        private string batteryInfo;
        private string batteryLife;
        private decimal price;

        public Laptop(string model, decimal price) : this (model, null, null, null, null, 
            null, null, null, price)
        {
        }

        public Laptop(string model, Battery battery, decimal price): this(model, null, null, null, null,
                null, null, battery, price)
        {
        }

        public Laptop(string model, string manufacturer, decimal price): this(model, manufacturer, null, null, null,
                null, null, null, price)
        {
        }

        public Laptop(string model, string memory, string disk, decimal price): this(model, null, null, memory, null,
                disk, null, null, price)
        {
        }

        public Laptop(string model, string memory, string disk, Battery battery, decimal price): this(model, null, null, memory, null,
                disk, null, battery, price)
        {
        }

        public Laptop(string model, string manufacturer, string processor, string memory, string graphicsCard, 
            string disk, string screen, Battery battery, decimal price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Processor = processor;
            Memory = memory;
            GraphicsCard = graphicsCard;
            Disk = disk;
            Screen = screen;
            BatteryInfo = battery != null ? battery.ToString() : null;
            BatteryLife = battery != null ? battery.BatteryLife() : null;
            Price = price;
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (value.Trim() == String.Empty || value == null)
                {
                    throw new ArgumentException("Model must have a value!");
                }
                model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == String.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                manufacturer = value;
            }
        }

        public string Processor
        {
            get { return processor; }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == String.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                processor = value;
            }
        }

        public string Memory
        {
            get { return memory; }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == String.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                memory = value;
            }
        }

        public string GraphicsCard
        {
            get { return graphicsCard; }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == String.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                graphicsCard = value;
            }
        }

        public string Disk
        {
            get { return disk; }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == String.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                disk = value;
            }
        }

        public string Screen
        {
            get { return screen; }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == String.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                screen = value;
            }
        }

        public string BatteryInfo
        {
            get { return batteryInfo; }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == String.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                batteryInfo = value;
            }
        }

        public string BatteryLife
        {
            get { return batteryLife; }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == String.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                batteryLife = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cannot be a negative number!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("{0,-15}{1}\n", "Model: ", Model));
            if (BatteryInfo != null && Memory == null)
            {
                sb.Append(String.Format("{0,-15}{1}\n", "Battery: ", BatteryInfo));
                sb.Append(String.Format("{0,-15}{1}\n", "Battery life: ", BatteryLife));
            }
            else if (Manufacturer != null && Processor == null)
            {
                sb.Append(String.Format("{0,-15}{1}\n", "Manufacturer: ", Manufacturer));
            }
            else if (Memory != null && BatteryInfo == null)
            {
                sb.Append(String.Format("{0,-15}{1}\n", "Memory: ", Memory));
                sb.Append(String.Format("{0,-15}{1}\n", "Disk: ", Disk));
            }
            else if (Memory != null && BatteryInfo != null && Manufacturer == null)
            {
                sb.Append(String.Format("{0,-15}{1}\n", "Memory: ", Memory));
                sb.Append(String.Format("{0,-15}{1}\n", "Disk: ", Disk));
                sb.Append(String.Format("{0,-15}{1}\n", "Battery: ", BatteryInfo));
                sb.Append(String.Format("{0,-15}{1}\n", "Battery life: ", BatteryLife));
            }
            else if (Manufacturer != null && Processor != null)
            {
                sb.Append(String.Format("{0,-15}{1}\n", "Manufacturer: ", Manufacturer));
                sb.Append(String.Format("{0,-15}{1}\n", "Processor: ", Processor));
                sb.Append(String.Format("{0,-15}{1}\n", "Memory: ", Memory));
                sb.Append(String.Format("{0,-15}{1}\n", "Graphics card: ", GraphicsCard));
                sb.Append(String.Format("{0,-15}{1}\n", "Disk: ", Disk));
                sb.Append(String.Format("{0,-15}{1}\n", "Screen: ", Screen));
                sb.Append(String.Format("{0,-15}{1}\n", "Battery: ", BatteryInfo));
                sb.Append(String.Format("{0,-15}{1}\n", "Battery life: ", BatteryLife));
            }
            sb.Append(String.Format("{0,-15}{1:C}\n", "Price: ", Price));
            return sb.ToString();
        }

    }
}
