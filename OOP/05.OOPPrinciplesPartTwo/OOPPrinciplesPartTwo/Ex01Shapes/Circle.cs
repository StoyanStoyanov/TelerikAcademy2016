namespace Ex01Shapes
{
    using System;

    public class Circle : Shape
    {
        public Circle(double width, double height)
            : base(width, height)
        {
            if (width != height)
            {
                throw new ArgumentException(string.Format("{0}'s width and height must be of equal value.", this.GetType().Name));
            }
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.Width * this.Height;
        }
    }
}