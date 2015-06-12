namespace _01.Shapes
{
    using System;
    using System.Globalization;
    using System.Threading;

    public static class Shapes
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            IShape[] shapes = { new Triangle(4, 5.6, 6.7), new Rectangle(4, 8), new Circle(4.5) };
            
            foreach (var shape in shapes)
            {
                Console.WriteLine("{0}area = {1, -6:F2} perimeter = {2:F2}", shape.GetType().Name.PadRight(10), shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
