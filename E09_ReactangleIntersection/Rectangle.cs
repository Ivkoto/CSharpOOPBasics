using System;

namespace E09_ReactangleIntersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.id = id;
            this.width = Math.Abs(width);
            this.height = Math.Abs(height);
            this.x = x;
            this.y = y;
        }

        public string Id { get { return id; } }
        public double Width { get { return width; } }
        public double Height { get { return height; } }
        public double X { get { return x; } }
        public double Y { get { return y; } }

        public bool IsRectangleIntersect(Rectangle two)
        {
            if (this.X <= (two.X + two.Width) && (this.X + this.Width) >= two.X && this.Y <= (two.Y + two.Height) && (this.Y + this.Height) >= two.Y)
            {
                return true;
            }
            return false;
        }
    }
}
