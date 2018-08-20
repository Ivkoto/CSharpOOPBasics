
namespace E05_DateModifier
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            Console.WriteLine(DateModifier.GetDateDifference(firstDate, secondDate));
        }
    }
}
