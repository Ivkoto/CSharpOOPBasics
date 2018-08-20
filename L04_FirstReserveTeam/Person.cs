using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string fName, string lName, int age, double salary)
    {
        this.FirstName = fName;
        this.LastName = lName;
        this.Age = age;
        this.Salary = salary;
    }

    public int Age
    {
        get { return this.age; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or negative integer");
            }
            this.age = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        private set
        {
            if (value.Length < 2)
            {
                throw new ArgumentException("Last name cannot be less than 3 symbols");
            }
            this.lastName = value;
        }
    }

    public string FirstName
    {
        get { return this.firstName; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new NullReferenceException("First name cannot be null or empty!");
            }
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot be less than 3 symbols");
            }
            this.firstName = value;
        }
    }

    public double Salary
    {
        get { return this.salary; }
        set
        {
            if (value < 460.0)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva");
            }
            this.salary = value;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this.salary:f2} leva";
    }

    public void IncreaseSalary(double bonus)
    {
        var salaryIncreasment = (bonus / 100) * this.Salary;

        if (this.age < 30)
        {
            this.Salary += salaryIncreasment / 2;
        }
        else
        {
            this.Salary += salaryIncreasment;
        }
    }
}