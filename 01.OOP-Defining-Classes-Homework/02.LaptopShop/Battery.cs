using System;

namespace _02.LaptopShop
{
    class Battery
    {
        private string cellType;
        private int numberOfCells;
        private int capacity;
        private double life;

        public Battery(int numberOfcells, int capacity, double life) : this(null, numberOfcells, capacity, life)
        {
        }

        public Battery(string cellType, int numberOfCells, int capacity, double life)
        {
            CellType = cellType;
            NumberOfCells = numberOfCells;
            Capacity = capacity;
            Life = life;
        }

        public string CellType
        {
            get {return cellType;}
            set
            {
                if (value.Trim() == String.Empty || value == null)
                {
                    cellType = "Unknown";
                }
                cellType = value;
            }
        }

        public int NumberOfCells
        {
            get { return numberOfCells; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Value cannot be zero or negative!");
                }
                numberOfCells = value;
            }
        }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Value cannot be zero or negative!");
                }
                capacity = value;
            }
        }

        public double Life
        {
            get { return life; }
            set
            {
                if (value < Double.Epsilon)
                {
                    throw new ArgumentException("Value cannot be zero or negative!");
                }
                life = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}-cells, {2} mAh", CellType, NumberOfCells, Capacity);
        }

        public string BatteryLife()
        {
            return String.Format("{0:F1} hours", Life);
        }
    }
}
