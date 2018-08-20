using System;

public class Person
{
    private string name;
    private int age;
    public Person(string name, int age)
    {
        this.Age = age;
        this.Name = name;
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
}
