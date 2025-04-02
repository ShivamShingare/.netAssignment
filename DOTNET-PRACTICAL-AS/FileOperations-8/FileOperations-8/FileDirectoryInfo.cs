using System;
using System.IO;

class FileDirectoryInfo
{
    public static void Run()
    {
        string path = "."; // Current Directory

        Console.WriteLine("=== Directory Information ===");
        DirectoryInfo dirInfo = new DirectoryInfo(path);
        Console.WriteLine("Full Path: " + dirInfo.FullName);
        Console.WriteLine("Creation Time: " + dirInfo.CreationTime);
        Console.WriteLine("Last Access Time: " + dirInfo.LastAccessTime);
        Console.WriteLine("Files in directory:");

        FileInfo[] files = dirInfo.GetFiles();
        foreach (FileInfo file in files)
        {
            Console.WriteLine($"File: {file.Name}, Size: {file.Length} bytes, Last Modified: {file.LastWriteTime}");
        }
    }
}
