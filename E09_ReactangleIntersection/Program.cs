namespace E09_ReactangleIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var rectangleCount = int.Parse(input[0]);            
            var intersectionCheck = int.Parse(input[1]);

            List<Rectangle> rectangles = RectangleAppend(rectangleCount);

            for (int i = 0; i < intersectionCheck; i++)
            {
                var intersectionIds = Console.ReadLine().Split(' ');

                var intersectOne = rectangles.Where(r => r.Id == intersectionIds[0]).FirstOrDefault();
                var intersectTwo = rectangles.Where(r => r.Id == intersectionIds[1]).FirstOrDefault();

                Console.WriteLine(intersectOne.IsRectangleIntersect(intersectTwo).ToString().ToLower());
            }
        }    

        private static List<Rectangle> RectangleAppend(int rectangleCount)
        {
            var rectangles = new List<Rectangle>();
            for (int i = 0; i < rectangleCount; i++)
            {
                var rectangleValues = Console.ReadLine().Split(' ');

                var id = rectangleValues[0];
                var width = double.Parse(rectangleValues[1]);
                var height = double.Parse(rectangleValues[2]);
                var x = double.Parse(rectangleValues[3]);
                var y = double.Parse(rectangleValues[4]);

                rectangles.Add(new Rectangle(id, width, height, x, y));
            }
            return rectangles;
        }
    }
}
