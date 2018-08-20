using System;
using System.Linq;
using System.Reflection;

namespace E02_ClassBoxDataValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            try
            {
                var box = new Box(length, width, height);

                Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.LeteralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }  
        }
    }
}