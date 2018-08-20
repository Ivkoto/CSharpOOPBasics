namespace E04_OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var peoples = new List<Person>();

            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var person = new Person(personInfo[0], int.Parse(personInfo[1]));
                peoples.Add(person);
            }

            foreach (Person person in peoples.Where(p => p.Age > 30).OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
