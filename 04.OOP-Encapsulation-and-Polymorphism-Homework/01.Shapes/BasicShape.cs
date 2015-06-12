namespace _01.Shapes
{
    using System;

    public abstract class BasicShape : IShape
    {
        private double width;

        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be a positive number greater than zero!", "value");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be a positive number greater than zero!", "value");
                }

                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}