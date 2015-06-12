namespace _01.Shapes
{
    using System;

    public sealed class Triangle : BasicShape
    {
        private double sideA;

        private double sideB;

        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
            : base(sideA, Math.Sqrt((sideA + sideB + sideC) / 2))
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public double SideA
        {
            get
            {
                return this.sideA;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Side must be a positive number greater than zero!", "value");
                }

                this.sideA = value;
            }
        }

        public double SideB
        {
            get
            {
                return this.sideB;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Side must be a positive number greater than zero!", "value");
                }

                this.sideB = value;
            }
        }

        public double SideC
        {
            get
            {
                return this.sideC;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Side must be a positive number greater than zero!", "value");
                }

                this.sideC = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.Sqrt((this.sideA + this.sideB + this.sideC) / 2);
        }

        public override double CalculatePerimeter()
        {
            return this.sideA + this.sideB + this.sideC;
        }
    }
}