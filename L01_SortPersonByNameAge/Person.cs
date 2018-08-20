using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string fName, string lName, int age)
    {
        this.FirstName = fName;
        this.LastName = lName;
        this.Age = age;
    }

    public int Age
    {
        get { return this.age; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The age must be larger than 0!");
            }
            this.age = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        private set { this.lastName = value; }
    }

    public string FirstName
    {
        get { return this.firstName; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new NullReferenceException("The name cannot be null or empty!");
            }
            this.firstName = value;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is a {this.Age} years old";
    }
}