using System;
using System.IO;

class TextFileOperations
{
    private static string filePath = "sample.txt";

    public static void Run()
    {
        WriteToFile();
        AppendToFile();
        ReadFromFile();
    }

    private static void WriteToFile()
    {
        File.WriteAllText(filePath, "Hello, this is the first line.\n");
        Console.WriteLine("File written successfully.");
    }

    private static void AppendToFile()
    {
        File.AppendAllText(filePath, "This is an appended line.\n");
        Console.WriteLine("Content appended to file.");
    }

    private static void ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("\nFile Content:\n" + content);
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}
