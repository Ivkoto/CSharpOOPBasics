using System;
using System.Collections.Generic;

internal class Program
{
    public static void Main()
    {
        List<Person> peoples = new List<Person>();
        var input = int.Parse(Console.ReadLine());
        for (int i = 0; i < input; i++)
        {
            var perArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                var person = new Person(perArgs[0], perArgs[1], int.Parse(perArgs[2]), double.Parse(perArgs[3]));
                peoples.Add(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        peoples.ForEach(p => Console.WriteLine(p.ToString()));
    }
}