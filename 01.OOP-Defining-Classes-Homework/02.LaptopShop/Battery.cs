namespace _02.LaptopShop
{
    using System;

    internal class Battery
    {
        private int capacity;

        private string cellType;

        private double life;

        private int numberOfCells;

        public Battery(int numberOfcells, int capacity, double life)
            : this(null, numberOfcells, capacity, life)
        {
        }

        public Battery(string cellType, int numberOfCells, int capacity, double life)
        {
            this.CellType = cellType;
            this.NumberOfCells = numberOfCells;
            this.Capacity = capacity;
            this.Life = life;
        }

        public string CellType
        {
            get
            {
                return this.cellType;
            }

            set
            {
                if (value.Trim() == string.Empty || value == null)
                {
                    this.cellType = "Unknown";
                }

                this.cellType = value;
            }
        }

        public int NumberOfCells
        {
            get
            {
                return this.numberOfCells;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Value cannot be zero or negative!");
                }

                this.numberOfCells = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Value cannot be zero or negative!");
                }

                this.capacity = value;
            }
        }

        public double Life
        {
            get
            {
                return this.life;
            }

            set
            {
                if (value < double.Epsilon)
                {
                    throw new ArgumentException("Value cannot be zero or negative!");
                }

                this.life = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}-cells, {2} mAh", this.CellType, this.NumberOfCells, this.Capacity);
        }

        public string BatteryLife()
        {
            return string.Format("{0:F1} hours", this.Life);
        }
    }
}