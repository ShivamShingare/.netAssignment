using System;

class Program
{
    static void Main()
    {
        // Create an Employee object
        Employee emp1 = new Employee("Alice", 30, "Software Developer");

        // Using the overridden method
        emp1.DisplayInfo();
        emp1.Greet(); // Calls Employee's Greet method

        // Using the new method
        emp1.Greet("Welcome to the IT department!");

        // Using the interface method
        emp1.DoWork();

        // Singleton Factory Method Example
        Employee emp2 = Employee.CreateEmployee("Bob", 28, "Data Analyst");
        emp2.DisplayInfo();  // Uses the same instance

        Console.ReadLine();  // Keeps the console open
    }
}
