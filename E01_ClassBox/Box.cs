namespace E01_ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
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