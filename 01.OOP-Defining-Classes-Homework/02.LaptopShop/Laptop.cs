namespace _02.LaptopShop
{
    using System;
    using System.Text;

    internal class Laptop
    {
        private string batteryInfo;

        private string batteryLife;

        private string disk;

        private string graphicsCard;

        private string manufacturer;

        private string memory;

        private string model;

        private decimal price;

        private string processor;

        private string screen;

        public Laptop(string model, decimal price)
            : this(model, null, null, null, null, null, null, null, price)
        {
        }

        public Laptop(string model, Battery battery, decimal price)
            : this(model, null, null, null, null, null, null, battery, price)
        {
        }

        public Laptop(string model, string manufacturer, decimal price)
            : this(model, manufacturer, null, null, null, null, null, null, price)
        {
        }

        public Laptop(string model, string memory, string disk, decimal price)
            : this(model, null, null, memory, null, disk, null, null, price)
        {
        }

        public Laptop(string model, string memory, string disk, Battery battery, decimal price)
            : this(model, null, null, memory, null, disk, null, battery, price)
        {
        }

        public Laptop(
            string model, 
            string manufacturer, 
            string processor, 
            string memory, 
            string graphicsCard, 
            string disk, 
            string screen, 
            Battery battery, 
            decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Memory = memory;
            this.GraphicsCard = graphicsCard;
            this.Disk = disk;
            this.Screen = screen;
            this.BatteryInfo = battery != null ? battery.ToString() : null;
            this.BatteryLife = battery != null ? battery.BatteryLife() : null;
            this.Price = price;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value.Trim() == string.Empty || value == null)
                {
                    throw new ArgumentException("Model must have a value!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }

                this.processor = value;
            }
        }

        public string Memory
        {
            get
            {
                return this.memory;
            }

            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }

                this.memory = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }

            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }

                this.graphicsCard = value;
            }
        }

        public string Disk
        {
            get
            {
                return this.disk;
            }

            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }

                this.disk = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }

                this.screen = value;
            }
        }

        public string BatteryInfo
        {
            get
            {
                return this.batteryInfo;
            }

            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }

                this.batteryInfo = value;
            }
        }

        public string BatteryLife
        {
            get
            {
                return this.batteryLife;
            }

            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }

                this.batteryLife = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cannot be a negative number!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("{0,-15}{1}\n", "Model: ", this.Model));
            if (this.BatteryInfo != null && this.Memory == null)
            {
                sb.Append(string.Format("{0,-15}{1}\n", "Battery: ", this.BatteryInfo));
                sb.Append(string.Format("{0,-15}{1}\n", "Battery life: ", this.BatteryLife));
            }
            else if (this.Manufacturer != null && this.Processor == null)
            {
                sb.Append(string.Format("{0,-15}{1}\n", "Manufacturer: ", this.Manufacturer));
            }
            else if (this.Memory != null && this.BatteryInfo == null)
            {
                sb.Append(string.Format("{0,-15}{1}\n", "Memory: ", this.Memory));
                sb.Append(string.Format("{0,-15}{1}\n", "Disk: ", this.Disk));
            }
            else if (this.Memory != null && this.BatteryInfo != null && this.Manufacturer == null)
            {
                sb.Append(string.Format("{0,-15}{1}\n", "Memory: ", this.Memory));
                sb.Append(string.Format("{0,-15}{1}\n", "Disk: ", this.Disk));
                sb.Append(string.Format("{0,-15}{1}\n", "Battery: ", this.BatteryInfo));
                sb.Append(string.Format("{0,-15}{1}\n", "Battery life: ", this.BatteryLife));
            }
            else if (this.Manufacturer != null && this.Processor != null)
            {
                sb.Append(string.Format("{0,-15}{1}\n", "Manufacturer: ", this.Manufacturer));
                sb.Append(string.Format("{0,-15}{1}\n", "Processor: ", this.Processor));
                sb.Append(string.Format("{0,-15}{1}\n", "Memory: ", this.Memory));
                sb.Append(string.Format("{0,-15}{1}\n", "Graphics card: ", this.GraphicsCard));
                sb.Append(string.Format("{0,-15}{1}\n", "Disk: ", this.Disk));
                sb.Append(string.Format("{0,-15}{1}\n", "Screen: ", this.Screen));
                sb.Append(string.Format("{0,-15}{1}\n", "Battery: ", this.BatteryInfo));
                sb.Append(string.Format("{0,-15}{1}\n", "Battery life: ", this.BatteryLife));
            }

            sb.Append(string.Format("{0,-15}{1:C}\n", "Price: ", this.Price));
            return sb.ToString();
        }
    }
}