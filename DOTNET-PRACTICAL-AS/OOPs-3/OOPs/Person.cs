using System;

public abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Public constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Abstract method (must be overridden in derived class)
    public abstract void DisplayInfo();

    // Virtual method (can be overridden)
    public virtual void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }
}
