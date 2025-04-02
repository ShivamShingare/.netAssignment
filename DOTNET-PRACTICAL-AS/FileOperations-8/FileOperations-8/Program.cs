using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1 - Text File Operations (Read, Write, Append)");
        Console.WriteLine("2 - Binary File Operations (Read, Write)");
        Console.WriteLine("3 - File and Directory Information");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                TextFileOperations.Run();
                break;
            case "2":
                BinaryFileOperations.Run();
                break;
            case "3":
                FileDirectoryInfo.Run();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                break;
        }
    }
}
