namespace E02_ClassBoxDataValidation
{
    using System;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        private double Length
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        private double Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            return (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
            //2lw + 2lh + 2wh
        }

        public double LeteralSurfaceArea()
        {
            return (2 * this.length * this.height) + (2 * this.width * this.height);
            //2lh + 2wh
        }

        public double Volume()
        {
            return this.length * this.width * this.height;
            //lwh
        }
    }
}