namespace Ex01Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;

        private double height;

        public Shape(double width, double height)
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

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format("{0}'s width can't be less than or equal to 0.", this.GetType().Name));
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

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format("{0}'s height can't be less than or equal to 0.", this.GetType().Name));
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            return string.Format("{0}(width: {1}, height: {2})", this.GetType().Name, this.Width, this.Height);
        }
    }
}