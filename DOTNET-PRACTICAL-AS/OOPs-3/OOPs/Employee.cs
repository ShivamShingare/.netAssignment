using System;

public class Employee : Person, IWork
{
    public string JobTitle { get; set; }
    private static Employee instance;

    // ✅ Public Constructor (Allows object creation)
    public Employee(string name, int age, string jobTitle) : base(name, age)
    {
        JobTitle = jobTitle;
    }

    // ✅ Private Constructor (Prevents direct instantiation)
    private Employee() : base("Default", 0) { }

    // ✅ Factory Method (Singleton Pattern)
    public static Employee CreateEmployee(string name, int age, string jobTitle)
    {
        if (instance == null)
        {
            instance = new Employee(name, age, jobTitle);
        }
        return instance;
    }

    // ✅ Override Abstract Method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Employee: {Name}, Age: {Age}, Job: {JobTitle}");
    }

    // ✅ Override Virtual Method
    public override void Greet()
    {
        Console.WriteLine($"Hi, I'm {Name}, a {JobTitle} at this company.");
    }

    // ✅ Implement Interface Method
    public void DoWork()
    {
        Console.WriteLine($"{Name} is working as a {JobTitle}.");
    }

    // ✅ New Method (Hides Parent's Method)
    public new void Greet(string message)
    {
        Console.WriteLine(message);
    }
}
