using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        var family = new Family();
        var lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            var member = Console.ReadLine().Split();
            var person = new Person(member[0], int.Parse(member[1]));
            family.AddMember(person);
        }
        var oldestMember = family.GetOldestMember();
        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }
}