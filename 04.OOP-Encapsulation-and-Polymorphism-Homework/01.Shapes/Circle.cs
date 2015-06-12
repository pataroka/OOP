namespace _01.Shapes
{
    using System;

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be a positive number greater than zero!", "value");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return this.Radius * 2 * Math.PI;
        }

        public double CalculatePerimeter()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}