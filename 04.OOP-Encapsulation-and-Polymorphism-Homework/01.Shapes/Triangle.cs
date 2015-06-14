namespace _01.Shapes
{
    using System;

    public sealed class Triangle : BasicShape
    {
        private double sideA;

        private double sideB;

        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
            : base(sideA, 0)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.Height = this.CalculateArea() * 2 / this.SideA;
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
            double p = this.CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - this.SideA) * (p - this.SideB) * (p - this.SideC));
        }

        public override double CalculatePerimeter()
        {
            return this.sideA + this.sideB + this.sideC;
        }
    }
}