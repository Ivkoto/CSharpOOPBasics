using E03_Manking.Models;
using System;

namespace E03_Manking
{
    public class Program
    {
        public static void Main()
        {
            var studArg = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var workerArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var student = new Student(studArg[0], studArg[1], studArg[2]);
                var worker = new Worker(workerArgs[0], workerArgs[1], decimal.Parse(workerArgs[2]), decimal.Parse(workerArgs[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}